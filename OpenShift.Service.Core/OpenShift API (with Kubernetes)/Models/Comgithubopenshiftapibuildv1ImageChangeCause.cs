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
    /// ImageChangeCause contains information about the image that triggered a
    /// build
    /// </summary>
    public partial class Comgithubopenshiftapibuildv1ImageChangeCause
    {
        /// <summary>
        /// Initializes a new instance of the
        /// Comgithubopenshiftapibuildv1ImageChangeCause class.
        /// </summary>
        public Comgithubopenshiftapibuildv1ImageChangeCause() { }

        /// <summary>
        /// Initializes a new instance of the
        /// Comgithubopenshiftapibuildv1ImageChangeCause class.
        /// </summary>
        public Comgithubopenshiftapibuildv1ImageChangeCause(Iok8sapicorev1ObjectReference fromRef = default(Iok8sapicorev1ObjectReference), string imageID = default(string))
        {
            FromRef = fromRef;
            ImageID = imageID;
        }

        /// <summary>
        /// fromRef contains detailed information about an image that
        /// triggered a build.
        /// </summary>
        [JsonProperty(PropertyName = "fromRef")]
        public Iok8sapicorev1ObjectReference FromRef { get; set; }

        /// <summary>
        /// imageID is the ID of the image that triggered a a new build.
        /// </summary>
        [JsonProperty(PropertyName = "imageID")]
        public string ImageID { get; set; }

    }
}