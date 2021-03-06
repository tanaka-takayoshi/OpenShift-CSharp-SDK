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
    /// ClusterRoleScopeRestriction describes restrictions on cluster role
    /// scopes
    /// </summary>
    public partial class Comgithubopenshiftapioauthv1ClusterRoleScopeRestriction
    {
        /// <summary>
        /// Initializes a new instance of the
        /// Comgithubopenshiftapioauthv1ClusterRoleScopeRestriction class.
        /// </summary>
        public Comgithubopenshiftapioauthv1ClusterRoleScopeRestriction() { }

        /// <summary>
        /// Initializes a new instance of the
        /// Comgithubopenshiftapioauthv1ClusterRoleScopeRestriction class.
        /// </summary>
        public Comgithubopenshiftapioauthv1ClusterRoleScopeRestriction(bool allowEscalation, IList<string> namespaces, IList<string> roleNames)
        {
            AllowEscalation = allowEscalation;
            Namespaces = namespaces;
            RoleNames = roleNames;
        }

        /// <summary>
        /// AllowEscalation indicates whether you can request roles and their
        /// escalating resources
        /// </summary>
        [JsonProperty(PropertyName = "allowEscalation")]
        public bool AllowEscalation { get; set; }

        /// <summary>
        /// Namespaces is the list of namespaces that can be referenced.  *
        /// means any of them (including *)
        /// </summary>
        [JsonProperty(PropertyName = "namespaces")]
        public IList<string> Namespaces { get; set; }

        /// <summary>
        /// RoleNames is the list of cluster roles that can referenced.  *
        /// means anything
        /// </summary>
        [JsonProperty(PropertyName = "roleNames")]
        public IList<string> RoleNames { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
            if (Namespaces == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Namespaces");
            }
            if (RoleNames == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "RoleNames");
            }
        }
    }
}
