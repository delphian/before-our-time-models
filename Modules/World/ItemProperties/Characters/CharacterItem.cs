﻿using BeforeOurTime.Models.Modules.Core.ItemProperties.Visibles;
using BeforeOurTime.Models.Modules.Core.Models.Items;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.Modules.World.ItemProperties.Characters
{
    /// <summary>
    /// Any item with an animating force
    /// </summary>
    public class CharacterItem : Item
    {
        /// <summary>
        /// Make an item visible
        /// </summary>
        [JsonProperty(PropertyName = "visible", Order = 100)]
        public VisibleItemProperty Visible
        {
            set { _visible = value; NotifyPropertyChanged("Visible"); }
            get
            {
                var value = _visible;
                if (value == null)
                {
                    Data?.ForEach((data) =>
                    {
                        value = data.GetProperty<VisibleItemProperty>("Visible", value);
                    });
                    _visible = value;
                }
                return value;
            }
        }
        private VisibleItemProperty _visible { set; get; }
        /// <summary>
        /// Constructor
        /// </summary>
        public CharacterItem()
        {
            Type = ItemType.Character;
        }
    }
}