﻿using BeforeOurTime.Models.ItemProperties.Game;
using BeforeOurTime.Models.ItemProperties.Visible;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.Items.Games
{
    /// <summary>
    /// Game wide definition and configurations
    /// </summary>
    public class GameItem : Item
    {
        /// <summary>
        /// Make an item visible
        /// </summary>
        [JsonProperty(PropertyName = "visible", Order = 100)]
        public VisibleProperty Visible
        {
            set { _visible = value; NotifyPropertyChanged("Visible"); }
            get
            {
                var value = _visible;
                if (value == null)
                {
                    Attributes?.ForEach((attribute) =>
                    {
                        value = attribute.GetProperty<VisibleProperty>("Visible", value);
                    });
                    Data?.ForEach((data) =>
                    {
                        value = data.GetProperty<VisibleProperty>("Visible", value);
                    });
                    _visible = value;
                }
                return value;
            }
        }
        private VisibleProperty _visible { set; get; }
        /// <summary>
        /// Game wide definition and configurations
        /// </summary>
        [JsonProperty(PropertyName = "game", Order = 110)]
        public GameProperty Game
        {
            set { _game = value; NotifyPropertyChanged("Game"); }
            get
            {
                var value = _game;
                if (value == null)
                {
                    Attributes?.ForEach((attribute) =>
                    {
                        value = attribute.GetProperty<GameProperty>("Game", value);
                    });
                    Data?.ForEach((data) =>
                    {
                        value = data.GetProperty<GameProperty>("Game", value);
                    });
                    _game = value;
                }
                return value;
            }
        }
        private GameProperty _game { set; get; }
        /// <summary>
        /// Constructor
        /// </summary>
        public GameItem()
        {
            Type = ItemType.Game;
        }
    }
}
