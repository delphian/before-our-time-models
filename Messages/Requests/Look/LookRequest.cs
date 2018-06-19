﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.Messages.Requests.Look
{
    public class LookRequest : Request, IRequest
    {
        /// <summary>
        /// Our unique message identifier
        /// </summary>
        public static Guid _Id = new Guid("a50d4898-22f6-46c3-b23b-69b866593b13");
        /// <summary>
        /// Constructor
        /// </summary>
        public LookRequest()
        {
            this.MessageId = _Id;
            this.MessageName = "Look Request";
        }
    }
}
