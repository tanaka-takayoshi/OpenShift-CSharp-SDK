using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.IO;
using System.Net.Http;

namespace OpenShift.OpenAPITransform
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new HttpClient();
            var tag = "release-3.9";
            var json = client.GetStringAsync($"https://raw.githubusercontent.com/openshift/origin/{tag}/api/swagger-spec/openshift-openapi-spec.json").GetAwaiter().GetResult();
            var jobj = JsonConvert.DeserializeObject(json) as JObject;
            
            //<argument>--directive={from: "swagger-document", where: "$..*[?(@.consumes[0] === \"*/*\")]", transform: "$.consumes[0] = \"application/json\""}</argument>
            foreach (var consume in jobj.SelectTokens("$..[?(@.consumes[0] == '*/*')]"))
            {
                consume.SelectToken("$.consumes[0]").Replace(JToken.FromObject("application/json"));
            }
            //produces should also have a type.
            foreach (var produce in jobj.SelectTokens("$..[?(@.produces[0] == '*/*')]"))
            {
                produce.SelectToken("$.produces[0]").Replace(JToken.FromObject("application/json"));
            }

            //<argument>--directive={from: "swagger-document", where: "$..*[?(@.operationId === \"readNamespacedPodLog\")]", transform: "$.responses[\"200\"].schema = { \"type\": \"object\", \"format\": \"file\" }"}</argument>
            foreach (var operationId in jobj.SelectTokens("$..[?(@.operationId == 'readNamespacedPodLog')]"))
            {
                operationId.SelectToken("$.responses['200'].schema").Replace(JToken.FromObject(new {type="object", format="file" }));
            }

            //<argument>--directive={from: "swagger-document", where: "$..*[?(@[\"x-kubernetes-action\"]=== \"proxy\")]", transform: "$.responses[\"200\"].schema = { \"type\": \"object\", \"format\": \"file\" }"}</argument>
            foreach (var action in jobj.SelectTokens("$..[?(@['x-kubernetes-action'] == 'proxy')]"))
            {
                action.SelectToken("$.responses['200'].schema").Replace(JToken.FromObject(new { type = "object", format = "file" }));
            }

            //<argument>--directive={from: "swagger-document", where: "$.definitions", transform: "$[\"intstr.IntOrString\"] = {\"properties\": { \"value\": { \"type\": \"string\" }}}"}</argument>
            //<argument>--directive={from: "swagger-document", where: "$.definitions", transform: "$[\"resource.Quantity\"] = {\"properties\": { \"value\": { \"type\": \"string\" }}}"}</argument>
            //<argument>--directive={from: "swagger-document", where: "$.definitions", transform: "$[\"v1.Patch\"] = {\"properties\": { \"content\": { \"type\": \"object\" }}}"}</argument>
            foreach (var definitions in jobj.SelectTokens("$.definitions"))
            {
                foreach (var t1 in definitions.SelectTokens("$['intstr.IntOrString']"))
                {
                    t1.Replace(JToken.FromObject(new { properties = new { value = new { type = "string" } } }));
                }
                foreach (var t2 in definitions.SelectTokens("$['resource.Quantity']"))
                {
                    t2.Replace(JToken.FromObject(new { properties = new { value = new { type = "string" } } }));
                }
                foreach (var t3 in definitions.SelectTokens("$['v1.Patch']"))
                {
                    t3.Replace(JToken.FromObject(new { properties = new { content = new { type = "object" } } }));
                }

            }
            
            //Remove uniqueItems if the parameter type is string, boolean or integer. UniqueItems is not working for these type in C#.
            foreach (var parameters in jobj.SelectTokens("$..parameters"))
            {
                var array = parameters as JArray;
                if (array == null)
                    continue;
                foreach (var param in array.Children())
                {
                    var p = param as JObject;
                    var isUnique = p?.Value<bool>("uniqueItems");
                    var type = p?.Value<string>("type");
                    if (isUnique == true && (type == "string" || type == "boolean" || type == "integer"))
                    {
                        p.Remove("uniqueItems");
                    }
                }
            }
            
            File.WriteAllText(@"./openshift-openapi-spec.json", JsonConvert.SerializeObject(jobj));
        }
    }
}
