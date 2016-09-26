// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Graph.RBAC.Models
{
    using System.Linq;

    /// <summary>
    /// Request parameters for updating an existing application
    /// </summary>
    public partial class ApplicationUpdateParametersInner
    {
        /// <summary>
        /// Initializes a new instance of the ApplicationUpdateParametersInner
        /// class.
        /// </summary>
        public ApplicationUpdateParametersInner() { }

        /// <summary>
        /// Initializes a new instance of the ApplicationUpdateParametersInner
        /// class.
        /// </summary>
        /// <param name="availableToOtherTenants">Indicates if the application
        /// will be available to other tenants</param>
        /// <param name="displayName">Application display name</param>
        /// <param name="homepage">Application homepage</param>
        /// <param name="identifierUris">Application Uris</param>
        /// <param name="replyUrls">Application reply Urls</param>
        /// <param name="keyCredentials">the list of KeyCredential
        /// objects</param>
        /// <param name="passwordCredentials">the list of PasswordCredential
        /// objects</param>
        public ApplicationUpdateParametersInner(bool? availableToOtherTenants = default(bool?), string displayName = default(string), string homepage = default(string), System.Collections.Generic.IList<string> identifierUris = default(System.Collections.Generic.IList<string>), System.Collections.Generic.IList<string> replyUrls = default(System.Collections.Generic.IList<string>), System.Collections.Generic.IList<KeyCredential> keyCredentials = default(System.Collections.Generic.IList<KeyCredential>), System.Collections.Generic.IList<PasswordCredential> passwordCredentials = default(System.Collections.Generic.IList<PasswordCredential>))
        {
            AvailableToOtherTenants = availableToOtherTenants;
            DisplayName = displayName;
            Homepage = homepage;
            IdentifierUris = identifierUris;
            ReplyUrls = replyUrls;
            KeyCredentials = keyCredentials;
            PasswordCredentials = passwordCredentials;
        }

        /// <summary>
        /// Gets or sets indicates if the application will be available to
        /// other tenants
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "availableToOtherTenants")]
        public bool? AvailableToOtherTenants { get; set; }

        /// <summary>
        /// Gets or sets application display name
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or sets application homepage
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "homepage")]
        public string Homepage { get; set; }

        /// <summary>
        /// Gets or sets application Uris
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "identifierUris")]
        public System.Collections.Generic.IList<string> IdentifierUris { get; set; }

        /// <summary>
        /// Gets or sets application reply Urls
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "replyUrls")]
        public System.Collections.Generic.IList<string> ReplyUrls { get; set; }

        /// <summary>
        /// Gets or sets the list of KeyCredential objects
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "keyCredentials")]
        public System.Collections.Generic.IList<KeyCredential> KeyCredentials { get; set; }

        /// <summary>
        /// Gets or sets the list of PasswordCredential objects
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "passwordCredentials")]
        public System.Collections.Generic.IList<PasswordCredential> PasswordCredentials { get; set; }

    }
}