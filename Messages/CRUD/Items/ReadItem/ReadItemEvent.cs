﻿using BeforeOurTime.Models.Items;
using BeforeOurTime.Models.Json;
using BeforeOurTime.Models.Messages.Events;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.Messages.CRUD.Items.ReadItem
{
    /// <summary>
    /// An item has been read with CRUD operations
    /// </summary>
    public class ReadItemEvent : Event, IEvent
    {
        /// <summary>
        /// Our unique message identifier
        /// </summary>
        [JsonIgnore]
        [JsonConverter(typeof(GuidJsonConverter))]
        public static Guid _Id = new Guid("3fdc8029-e67f-4d6c-819e-1adc4ef91b47");
        /// <summary>
        /// Item that has been read
        /// </summary>
        [JsonProperty(PropertyName = "item", Order = 1100)]
        public Item Item { set; get; }
        /// <summary>
        /// Constructor
        /// </summary>
        public ReadItemEvent()
        {
            this.MessageId = _Id;
            this.MessageName = "Item has been read via CRUD";
        }
    }
}
