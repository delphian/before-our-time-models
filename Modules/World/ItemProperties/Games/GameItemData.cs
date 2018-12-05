﻿using BeforeOurTime.Models.Modules.Core.Models.Data;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.Modules.World.ItemProperties.Games
{
    /// <summary>
    /// A game environmnent containing users, locations, items, and unique rules
    /// </summary>
    public class GameItemData : ItemData, IItemData
    {
        /// <summary>
        /// Default location of a new item when parent is not specified
        /// </summary>
        [JsonProperty(PropertyName = "defaultLocationId")]
        public Guid? DefaultLocationId { set; get; }
        /// <summary>
        /// Constructor
        /// </summary>
        public GameItemData()
        {
            DataType = this.GetType().ToString();
        }
        /// <summary>
        /// Populate an item property value
        /// </summary>
        /// <typeparam name="T">Type of property to populate with value</typeparam>
        /// <param name="propertyName">Name of item property to populate with value</param>
        /// <param name="previousValue">Value assigned to property by previous attribute</param>
        /// <returns></returns>
        public override T GetProperty<T>(string propertyName, object previousValue)
        {
            return (T)previousValue;
        }
    }
}