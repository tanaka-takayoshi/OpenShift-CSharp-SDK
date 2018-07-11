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
    /// TokenReviewSpec is a description of the token authentication request.
    /// </summary>
    public partial class Iok8sapiauthenticationv1beta1TokenReviewSpec
    {
        /// <summary>
        /// Initializes a new instance of the
        /// Iok8sapiauthenticationv1beta1TokenReviewSpec class.
        /// </summary>
        public Iok8sapiauthenticationv1beta1TokenReviewSpec() { }

        /// <summary>
        /// Initializes a new instance of the
        /// Iok8sapiauthenticationv1beta1TokenReviewSpec class.
        /// </summary>
        public Iok8sapiauthenticationv1beta1TokenReviewSpec(string token = default(string))
        {
            Token = token;
        }

        /// <summary>
        /// Token is the opaque bearer token.
        /// </summary>
        [JsonProperty(PropertyName = "token")]
        public string Token { get; set; }

    }
}