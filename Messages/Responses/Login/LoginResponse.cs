﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.Messages.Responses.Login
{
    /// <summary>
    /// Response to login request
    /// </summary>
    public class LoginResponse : Response, IResponse
    {
        /// <summary>
        /// Unique account identifier
        /// </summary>
        public Guid? AccountId { set; get; }
        /// <summary>
        /// Constructor
        /// </summary>
        public LoginResponse()
        {
            this.MessageId = new Guid("dbee9538-048c-4ea7-b518-8b6cc17fdeb7");
            this.MessageName = "Login Response";
        }
    }
}
