﻿using BeforeOurTime.Models.Modules.Core.Models.Data;
using BeforeOurTime.Models.Modules.Core.Models.Properties;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.Modules.World.ItemProperties.Physicals
{
    /// <summary>
    /// An item perceived through the senses, tangible and concrete
    /// </summary>
    public class PhysicalItemData : ItemData, IItemData
    {
        /// <summary>
        /// Item may be moved
        /// </summary>
        [JsonProperty(PropertyName = "mobile", Order = 50)]
        public bool Mobile { set; get; }
        /// <summary>
        /// Weight of item
        /// </summary>
        [JsonProperty(PropertyName = "weight", Order = 60)]
        public int Weight { set; get; }
        /// <summary>
        /// Constructor
        /// </summary>
        public PhysicalItemData()
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