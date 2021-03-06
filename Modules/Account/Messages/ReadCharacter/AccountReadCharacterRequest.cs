﻿using BeforeOurTime.Models.Json;
using BeforeOurTime.Models.Messages.Requests;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.Modules.Account.Messages.ReadCharacter
{
    public class AccountReadCharacterRequest : Request, IRequest
    {
        /// <summary>
        /// Our unique message identifier
        /// </summary>
        [JsonIgnore]
        [JsonConverter(typeof(GuidJsonConverter))]
        public static Guid _Id = new Guid("afea0f2d-83cf-48ce-ab0f-3555417bfab9");
        /// <summary>
        /// Unique account identifier of player to list characters of
        /// </summary>
        [JsonConverter(typeof(GuidJsonConverter))]
        [JsonProperty(PropertyName = "accountId", Order = 1000)]
        public Guid AccountId { set; get; }
        /// <summary>
        /// Constructor
        /// </summary>
        public AccountReadCharacterRequest()
        {
            this.MessageId = _Id;
            this.MessageName = "Account Read Character Request";
        }
    }
}
