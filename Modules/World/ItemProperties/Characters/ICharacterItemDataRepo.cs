﻿using BeforeOurTime.Models.Modules.Core.Models.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.Modules.World.ItemProperties.Characters
{
    /// <summary>
    /// Central data repository for all character items
    /// </summary>
    public interface ICharacterItemDataRepo : ICrudItemModelRepository<CharacterItemData>
    {
        /// <summary>
        /// Read associated character data of item
        /// </summary>
        /// <param name="item">Item that may have associated data</param>
        /// <returns></returns>
        CharacterItemData Read(Item item);
        /// <summary>
        /// Read associated character data of item id
        /// </summary>
        /// <param name="itemId">Item id that may have associated data</param>
        /// <returns></returns>
        CharacterItemData ReadItemId(Guid itemId);
    }
}
