﻿using BeforeOurTime.Models.Messages;
using BeforeOurTime.Models.Modules.Core.Models.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.Modules.Core.Managers
{
    /// <summary>
    /// Pass messages between items and terminals
    /// </summary>
    public interface IMessageManager : IModelManager
    {
        /// <summary>
        /// Send one or more messages to one or more items
        /// </summary>
        /// <param name="messages">List of messages to send</param>
        /// <param name="items">List of items to send messages to</param>
        /// <param name="origin">Origin of the messages</param>
        void SendMessage(List<IMessage> messages, List<Item> items, Item origin = null);
        /// <summary>
        /// Send messages to recipient and all of it's siblings
        /// </summary>
        /// <param name="messages">List of messages to send</param>
        /// <param name="recipient">Recipient to send messages to</param>
        /// <param name="origin">Origin of the messages</param>
        void SendMessageToSiblings(List<IMessage> messages, Item recipient, Item origin = null);
        /// <summary>
        /// Send one message to one or more items
        /// </summary>
        /// <param name="messages">List of messages to send</param>
        /// <param name="items">List of items to send messages to</param>
        /// <param name="origin">Origin of the messages</param>
        void SendMessage(IMessage messages, List<Item> items, Item origin = null);
    }
}
