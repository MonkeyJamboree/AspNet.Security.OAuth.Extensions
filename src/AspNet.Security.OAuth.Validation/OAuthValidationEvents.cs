﻿/*
 * Licensed under the Apache License, Version 2.0 (http://www.apache.org/licenses/LICENSE-2.0)
 * See https://github.com/aspnet-contrib/AspNet.Security.OAuth.Extensions for more information
 * concerning the license and the contributors participating to this project.
 */

using System;
using System.Threading.Tasks;

namespace AspNet.Security.OAuth.Validation {
    /// <summary>
    /// Allows customization of validation handling within the middleware.
    /// </summary>
    public class OAuthValidationEvents : IOAuthValidationEvents {
        /// <summary>
        /// Invoked when a ticket is to be created from an introspection response.
        /// </summary>
        public Func<CreateTicketContext, Task> OnCreateTicket { get; set; } = context => Task.FromResult(0);

        /// <summary>
        /// Invoked when a token is to be parsed from a newly-received request.
        /// </summary>
        public Func<RetrieveTokenContext, Task> OnRetrieveToken { get; set; } = context => Task.FromResult(0);

        /// <summary>
        /// Invoked when a token is to be validated, before final processing.
        /// </summary>
        public Func<ValidateTokenContext, Task> OnValidateToken { get; set; } = context => Task.FromResult(0);

        /// <summary>
        /// Invoked when a ticket is to be created from an introspection response.
        /// </summary>
        public virtual Task CreateTicket(CreateTicketContext context) => OnCreateTicket(context);

        /// <summary>
        /// Invoked when a token is to be parsed from a newly-received request.
        /// </summary>
        public virtual Task RetrieveToken(RetrieveTokenContext context) => OnRetrieveToken(context);

        /// <summary>
        /// Invoked when a token is to be validated, before final processing.
        /// </summary>
        public virtual Task ValidateToken(ValidateTokenContext context) => OnValidateToken(context);
    }
}
