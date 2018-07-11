﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace OpenShift.Service.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;

    /// <summary>
    /// BuildSpec has the information to represent a build and also additional
    /// information about a build
    /// </summary>
    public partial class Comgithubopenshiftapibuildv1BuildSpec
    {
        /// <summary>
        /// Initializes a new instance of the
        /// Comgithubopenshiftapibuildv1BuildSpec class.
        /// </summary>
        public Comgithubopenshiftapibuildv1BuildSpec() { }

        /// <summary>
        /// Initializes a new instance of the
        /// Comgithubopenshiftapibuildv1BuildSpec class.
        /// </summary>
        public Comgithubopenshiftapibuildv1BuildSpec(IDictionary<string, string> nodeSelector, Comgithubopenshiftapibuildv1BuildStrategy strategy, IList<Comgithubopenshiftapibuildv1BuildTriggerCause> triggeredBy, long? completionDeadlineSeconds = default(long?), Comgithubopenshiftapibuildv1BuildOutput output = default(Comgithubopenshiftapibuildv1BuildOutput), Comgithubopenshiftapibuildv1BuildPostCommitSpec postCommit = default(Comgithubopenshiftapibuildv1BuildPostCommitSpec), Iok8sapicorev1ResourceRequirements resources = default(Iok8sapicorev1ResourceRequirements), Comgithubopenshiftapibuildv1SourceRevision revision = default(Comgithubopenshiftapibuildv1SourceRevision), string serviceAccount = default(string), Comgithubopenshiftapibuildv1BuildSource source = default(Comgithubopenshiftapibuildv1BuildSource))
        {
            CompletionDeadlineSeconds = completionDeadlineSeconds;
            NodeSelector = nodeSelector;
            Output = output;
            PostCommit = postCommit;
            Resources = resources;
            Revision = revision;
            ServiceAccount = serviceAccount;
            Source = source;
            Strategy = strategy;
            TriggeredBy = triggeredBy;
        }

        /// <summary>
        /// completionDeadlineSeconds is an optional duration in seconds,
        /// counted from the time when a build pod gets scheduled in the
        /// system, that the build may be active on a node before the system
        /// actively tries to terminate the build; value must be positive
        /// integer
        /// </summary>
        [JsonProperty(PropertyName = "completionDeadlineSeconds")]
        public long? CompletionDeadlineSeconds { get; set; }

        /// <summary>
        /// nodeSelector is a selector which must be true for the build pod to
        /// fit on a node If nil, it can be overridden by default build
        /// nodeselector values for the cluster. If set to an empty map or a
        /// map with any values, default build nodeselector values are
        /// ignored.
        /// </summary>
        [JsonProperty(PropertyName = "nodeSelector")]
        public IDictionary<string, string> NodeSelector { get; set; }

        /// <summary>
        /// output describes the Docker image the Strategy should produce.
        /// </summary>
        [JsonProperty(PropertyName = "output")]
        public Comgithubopenshiftapibuildv1BuildOutput Output { get; set; }

        /// <summary>
        /// postCommit is a build hook executed after the build output image
        /// is committed, before it is pushed to a registry.
        /// </summary>
        [JsonProperty(PropertyName = "postCommit")]
        public Comgithubopenshiftapibuildv1BuildPostCommitSpec PostCommit { get; set; }

        /// <summary>
        /// resources computes resource requirements to execute the build.
        /// </summary>
        [JsonProperty(PropertyName = "resources")]
        public Iok8sapicorev1ResourceRequirements Resources { get; set; }

        /// <summary>
        /// revision is the information from the source for a specific repo
        /// snapshot. This is optional.
        /// </summary>
        [JsonProperty(PropertyName = "revision")]
        public Comgithubopenshiftapibuildv1SourceRevision Revision { get; set; }

        /// <summary>
        /// serviceAccount is the name of the ServiceAccount to use to run the
        /// pod created by this build. The pod will be allowed to use secrets
        /// referenced by the ServiceAccount
        /// </summary>
        [JsonProperty(PropertyName = "serviceAccount")]
        public string ServiceAccount { get; set; }

        /// <summary>
        /// source describes the SCM in use.
        /// </summary>
        [JsonProperty(PropertyName = "source")]
        public Comgithubopenshiftapibuildv1BuildSource Source { get; set; }

        /// <summary>
        /// strategy defines how to perform a build.
        /// </summary>
        [JsonProperty(PropertyName = "strategy")]
        public Comgithubopenshiftapibuildv1BuildStrategy Strategy { get; set; }

        /// <summary>
        /// triggeredBy describes which triggers started the most recent
        /// update to the build configuration and contains information about
        /// those triggers.
        /// </summary>
        [JsonProperty(PropertyName = "triggeredBy")]
        public IList<Comgithubopenshiftapibuildv1BuildTriggerCause> TriggeredBy { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
            if (NodeSelector == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "NodeSelector");
            }
            if (Strategy == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Strategy");
            }
            if (TriggeredBy == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "TriggeredBy");
            }
            if (this.Revision != null)
            {
                this.Revision.Validate();
            }
            if (this.Source != null)
            {
                this.Source.Validate();
            }
            if (this.Strategy != null)
            {
                this.Strategy.Validate();
            }
            if (this.TriggeredBy != null)
            {
                foreach (var element in this.TriggeredBy)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
        }
    }
}