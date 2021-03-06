﻿using BeforeOurTime.Models.Messages.Events;
using BeforeOurTime.Models.Modules.Core.Messages.MoveItem;
using BeforeOurTime.Models.Modules.Core.Models.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.Modules.Core.Managers
{
    /// <summary>
    /// Delegate format to receive item manager generated events with
    /// </summary>
    /// <param name="e">IEvent</param>
    public delegate void ItemEventDelegate(IEvent e);
    /// <summary>
    /// Manages security, environment messages, CRUD, and run time considerations for items
    /// </summary>
    public interface IItemManager : IModelManager
    {
        /// <summary>
        /// Subscribe to receive updates when an item changes locations
        /// </summary>
        event ItemEventDelegate ItemMoveEvent;
        /// <summary>
        /// Create a new item
        /// </summary>
        /// <param name="item">Item which is new and being created</param>
        Item Create(Item item);
        /// <summary>
        /// Read single model of a type derived from Item
        /// </summary>
        /// <param name="itemIds">Unique item identifier</param>
        /// <returns></returns>
        Item Read(Guid itemId);
        /// <summary>
        /// Read multiple models of a type derived from Item
        /// </summary>
        /// <param name="itemIds">List of unique item identifiers</param>
        /// <returns></returns>
        List<Item> Read(List<Guid> itemIds);
        /// <summary>
        /// Read all models of a type derived from Item, or specify an offset and limit
        /// </summary>
        /// <remarks>
        /// If repository was instanted with type Item (T) then this method may be used to 
        /// read any model (TDerived) that is derived from type T (Item)
        /// </remarks>
        /// <param name="offset">Number of model records to skip</param>
        /// <param name="limit">Maximum number of model records to return</param>
        /// <returns></returns>
        List<Item> Read(int? offset = null, int? limit = null);
        /// <summary>
        /// Get the item identifiers of all item's children
        /// </summary>
        /// <param name="itemId">Unique item identifier of potential parent</param>
        /// <returns></returns>
        List<Guid> GetChildrenIds(Guid itemId);
        /// <summary>
        /// Update multiple models derived from Item
        /// </summary>
        /// <param name="itemIds">List of unique item identifiers</param>
        /// <returns></returns>
        List<Item> Update(List<Item> items);
        /// <summary>
        /// Update any model that is derived from type Item
        /// </summary>
        /// <param name="item">Item to be updated</param>
        /// <returns></returns>
        Item Update(Item item);
        /// <summary>
        /// Permenantly delete an item and remove from data store
        /// </summary>
        /// <remarks>
        /// All children will be re-homed to the item parent unless otherwise specified
        /// </remarks>
        /// <param name="item">List of items to delete</param>
        /// <param name="deleteChildren">Also delete all children</param>
        void Delete(List<Item> items, bool? deleteChildren = false);
        /// <summary>
        /// Relocate an item
        /// </summary>
        /// <param name="item">Item to move</param>
        /// <param name="newParent">Item which will become the parent</param>
        /// <param name="source">Item responsible for doing the moving</param>
        Item Move(Item item, Item newParent, Item source = null);
    }
}
