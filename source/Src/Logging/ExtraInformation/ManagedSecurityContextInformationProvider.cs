﻿// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

using System.Collections.Generic;
using System.Threading;

namespace Microsoft.Practices.EnterpriseLibrary.Logging.ExtraInformation
{
    /// <summary>
    /// Provides useful diagnostic information from the managed runtime.
    /// </summary>
    public class ManagedSecurityContextInformationProvider : IExtraInformationProvider
    {
        /// <summary>
        /// Populates an <see cref="IDictionary{K,T}"/> with helpful diagnostic information.
        /// </summary>
        /// <param name="dict">Dictionary used to populate the <see cref="ManagedSecurityContextInformationProvider"></see></param>
        public void PopulateDictionary(IDictionary<string, object> dict)
        {
            dict.Add(Properties.Resources.ManagedSecurity_AuthenticationType, AuthenticationType);
            dict.Add(Properties.Resources.ManagedSecurity_IdentityName, IdentityName);
            dict.Add(Properties.Resources.ManagedSecurity_IsAuthenticated, IsAuthenticated.ToString());
        }

        /// <summary>
        ///        Gets the AuthenticationType, calculating it if necessary. 
        /// </summary>
        public string AuthenticationType
        {
            get { return Thread.CurrentPrincipal.Identity.AuthenticationType; }
        }

        /// <summary>
        ///        Gets the IdentityName, calculating it if necessary. 
        /// </summary>
        public string IdentityName
        {
            get { return Thread.CurrentPrincipal.Identity.Name; }
        }

        /// <summary>
        ///        Gets the IsAuthenticated, calculating it if necessary. 
        /// </summary>
        public bool IsAuthenticated
        {
            get { return Thread.CurrentPrincipal.Identity.IsAuthenticated; }
        }
    }
}
