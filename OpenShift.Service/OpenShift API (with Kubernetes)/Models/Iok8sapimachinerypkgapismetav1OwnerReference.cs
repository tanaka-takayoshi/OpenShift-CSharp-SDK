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
    /// OwnerReference contains enough information to let you identify an
    /// owning object. Currently, an owning object must be in the same
    /// namespace, so there is no namespace field.
    /// </summary>
    public partial class Iok8sapimachinerypkgapismetav1OwnerReference
    {
        /// <summary>
        /// Initializes a new instance of the
        /// Iok8sapimachinerypkgapismetav1OwnerReference class.
        /// </summary>
        public Iok8sapimachinerypkgapismetav1OwnerReference() { }

        /// <summary>
        /// Initializes a new instance of the
        /// Iok8sapimachinerypkgapismetav1OwnerReference class.
        /// </summary>
        public Iok8sapimachinerypkgapismetav1OwnerReference(string apiVersion, string kind, string name, string uid, bool? blockOwnerDeletion = default(bool?), bool? controller = default(bool?))
        {
            ApiVersion = apiVersion;
            BlockOwnerDeletion = blockOwnerDeletion;
            Controller = controller;
            Kind = kind;
            Name = name;
            Uid = uid;
        }

        /// <summary>
        /// API version of the referent.
        /// </summary>
        [JsonProperty(PropertyName = "apiVersion")]
        public string ApiVersion { get; set; }

        /// <summary>
        /// If true, AND if the owner has the "foregroundDeletion" finalizer,
        /// then the owner cannot be deleted from the key-value store until
        /// this reference is removed. Defaults to false. To set this field,
        /// a user needs "delete" permission of the owner, otherwise 422
        /// (Unprocessable Entity) will be returned.
        /// </summary>
        [JsonProperty(PropertyName = "blockOwnerDeletion")]
        public bool? BlockOwnerDeletion { get; set; }

        /// <summary>
        /// If true, this reference points to the managing controller.
        /// </summary>
        [JsonProperty(PropertyName = "controller")]
        public bool? Controller { get; set; }

        /// <summary>
        /// Kind of the referent. More info:
        /// https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds
        /// </summary>
        [JsonProperty(PropertyName = "kind")]
        public string Kind { get; set; }

        /// <summary>
        /// Name of the referent. More info:
        /// http://kubernetes.io/docs/user-guide/identifiers#names
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// UID of the referent. More info:
        /// http://kubernetes.io/docs/user-guide/identifiers#uids
        /// </summary>
        [JsonProperty(PropertyName = "uid")]
        public string Uid { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
            if (ApiVersion == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ApiVersion");
            }
            if (Kind == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Kind");
            }
            if (Name == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Name");
            }
            if (Uid == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Uid");
            }
        }
    }
}