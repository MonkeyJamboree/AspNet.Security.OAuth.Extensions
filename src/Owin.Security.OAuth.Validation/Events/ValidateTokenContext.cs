﻿/*
 * Licensed under the Apache License, Version 2.0 (http://www.apache.org/licenses/LICENSE-2.0)
 * See https://github.com/aspnet-contrib/AspNet.Security.OAuth.Extensions for more information
 * concerning the license and the contributors participating to this project.
 */

using JetBrains.Annotations;
using Microsoft.Owin;
using Microsoft.Owin.Security;
using Microsoft.Owin.Security.Notifications;

namespace Owin.Security.OAuth.Validation {
    /// <summary>
    /// Allows customization of the token validation logic.
    /// </summary>
    public class ValidateTokenContext : BaseNotification<OAuthValidationOptions> {
        public ValidateTokenContext(
            [NotNull] IOwinContext context,
            [NotNull] OAuthValidationOptions options,
            [NotNull] AuthenticationTicket ticket)
            : base(context, options) {
            Ticket = ticket;
        }

        /// <summary>
        /// Gets or sets the <see cref="AuthenticationTicket"/>
        /// extracted from the access token.
        /// </summary>
        public AuthenticationTicket Ticket { get; set; }
    }
}
