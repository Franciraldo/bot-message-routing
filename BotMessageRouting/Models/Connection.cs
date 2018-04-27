﻿using Microsoft.Bot.Schema;
using System;
using Newtonsoft.Json;
using Underscore.Bot.MessageRouting.DataStore;

namespace Underscore.Bot.Models
{
    [Serializable]
    public class Connection : IEquatable<Connection>
    {
        /// <summary>
        /// Represents the last time in which user and agent interact in the connection.
        /// TODO: We had to change the value every time there is an interaction between the two.
        /// </summary>
        public DateTime LastInteractionTime
        {
            get;
            set;
        }

        public ConversationReference ConversationReference1
        {
            get;
            set;
        }

        public ConversationReference ConversationReference2
        {
            get;
            set;
        }

        public Connection(ConversationReference conversationReference1, ConversationReference conversationReference2)
        {
            ConversationReference1 = conversationReference1;
            ConversationReference2 = conversationReference2;
            LastInteractionTime = DateTime.Now;
        }

        /// <summary>
        /// Checks if the given connection matches this one.
        /// </summary>
        /// <param name="other">The other connection.</param>
        /// <returns>True, if the connections are match. False otherwise.</returns>
        public bool Equals(Connection other)
        {
            return (other != null
                && ((RoutingDataManager.HasMatchingChannelAccounts(ConversationReference1, other.ConversationReference1)
                     && RoutingDataManager.HasMatchingChannelAccounts(ConversationReference2, other.ConversationReference2))
                     || (RoutingDataManager.HasMatchingChannelAccounts(ConversationReference1, other.ConversationReference2)
                         && RoutingDataManager.HasMatchingChannelAccounts(ConversationReference2, other.ConversationReference1))));
        }

        public static Connection FromJson(string connectionAsJsonString)
        {
            Connection connection = null;

            try
            {
                connection = JsonConvert.DeserializeObject<Connection>(connectionAsJsonString);
            }
            catch (Exception)
            {
            }

            return connection;
        }

        public string ToJson()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}
