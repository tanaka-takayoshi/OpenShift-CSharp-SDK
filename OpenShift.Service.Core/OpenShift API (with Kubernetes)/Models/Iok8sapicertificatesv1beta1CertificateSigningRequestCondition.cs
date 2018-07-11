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

    public partial class Iok8sapicertificatesv1beta1CertificateSigningRequestCondition
    {
        /// <summary>
        /// Initializes a new instance of the
        /// Iok8sapicertificatesv1beta1CertificateSigningRequestCondition
        /// class.
        /// </summary>
        public Iok8sapicertificatesv1beta1CertificateSigningRequestCondition() { }

        /// <summary>
        /// Initializes a new instance of the
        /// Iok8sapicertificatesv1beta1CertificateSigningRequestCondition
        /// class.
        /// </summary>
        public Iok8sapicertificatesv1beta1CertificateSigningRequestCondition(string type, DateTime? lastUpdateTime = default(DateTime?), string message = default(string), string reason = default(string))
        {
            LastUpdateTime = lastUpdateTime;
            Message = message;
            Reason = reason;
            Type = type;
        }

        /// <summary>
        /// timestamp for the last update to this condition
        /// </summary>
        [JsonProperty(PropertyName = "lastUpdateTime")]
        public DateTime? LastUpdateTime { get; set; }

        /// <summary>
        /// human readable message with details about the request state
        /// </summary>
        [JsonProperty(PropertyName = "message")]
        public string Message { get; set; }

        /// <summary>
        /// brief reason for the request state
        /// </summary>
        [JsonProperty(PropertyName = "reason")]
        public string Reason { get; set; }

        /// <summary>
        /// request approval state, currently Approved or Denied.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
            if (Type == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Type");
            }
        }
    }
}