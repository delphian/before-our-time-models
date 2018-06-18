﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.Messages.Responses.List
{
    /// <summary>
    /// Enumerate an exit
    /// </summary>
    public class ListExitResponse : Response, IResponse
    {
        /// <summary>
        /// Unique exit item identifier
        /// </summary>
        public Guid ItemId { set; get; }
        /// <summary>
        /// Name of the exit
        /// </summary>
        public string Name { set; get; }
        /// <summary>
        /// Description of exit
        /// </summary>
        public string Description { set; get; }
        /// <summary>
        /// Constructor
        /// </summary>
        public ListExitResponse()
        {
            this.MessageId = new Guid("88f8dbfe-cd70-4da4-97cf-6eeeadc7b861");
            this.MessageName = "List Exit Response";
        }
    }
}
