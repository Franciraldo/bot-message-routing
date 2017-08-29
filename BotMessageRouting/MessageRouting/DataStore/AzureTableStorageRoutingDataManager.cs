﻿using System;
using System.Collections.Generic;
using Microsoft.Bot.Connector;
using Microsoft.WindowsAzure.Storage;
using Microsoft.Azure;
using Underscore.Bot.Models;

namespace Underscore.Bot.MessageRouting.DataStore
{
    /// <summary>
    /// Routing data manager that stores the data in Azure Table storage services.
    /// Caching policy: If the local query finds nothing, update the data from the storage.
    /// See IRoutingDataManager for general documentation of properties and methods.
    /// 
    /// NOTE: DO NOT USE THIS CLASS - THIS IS NOT FAR FROM A PLACEHOLDER CURRENTLY
    /// 
    /// See also Get started with Azure Table storage using .NET article:
    /// https://docs.microsoft.com/en-us/azure/storage/storage-dotnet-how-to-use-tables
    /// </summary>
    public class AzureTableStorageRoutingDataManager : IRoutingDataManager
    {
        private const string StorageConnectionStringId = "RoutingDataStorageConnectionString";
        private string _connectionString;

        /// <summary>
        /// Constructor.
        /// </summary>
        public AzureTableStorageRoutingDataManager()
        {
            _connectionString = CloudConfigurationManager.GetSetting(StorageConnectionStringId);
            CloudStorageAccount cloudStorageAccount = CloudStorageAccount.Parse(_connectionString);
        }

        public bool AddAggregationParty(Party party)
        {
            throw new NotImplementedException();
        }

        public MessageRouterResult ConnectAndClearPendingRequest(Party conversationOwnerParty, Party conversationClientParty)
        {
            throw new NotImplementedException();
        }

        public bool AddParty(Party newParty, bool isUser = true)
        {
            throw new NotImplementedException();
        }

        public bool AddParty(string serviceUrl, string channelId, ChannelAccount channelAccount, ConversationAccount conversationAccount, bool isUser = true)
        {
            throw new NotImplementedException();
        }

        public MessageRouterResult AddPendingRequest(Party party)
        {
            throw new NotImplementedException();
        }

        public void DeleteAll()
        {
            throw new NotImplementedException();
        }

        public string ConnectionsToString()
        {
            throw new NotImplementedException();
        }

        public Party FindBotPartyByChannelAndConversation(string channelId, ConversationAccount conversationAccount)
        {
            throw new NotImplementedException();
        }

        public Party FindConnectedPartyByChannel(string channelId, ChannelAccount channelAccount)
        {
            throw new NotImplementedException();
        }

        public Party FindExistingUserParty(Party partyToFind)
        {
            throw new NotImplementedException();
        }

        public IList<Party> FindPartiesWithMatchingChannelAccount(Party partyToFind, IList<Party> parties)
        {
            throw new NotImplementedException();
        }

        public Party FindPartyByChannelAccountIdAndConversationId(string channelAccountId, string conversationId)
        {
            throw new NotImplementedException();
        }

        public IList<Party> GetAggregationParties()
        {
            throw new NotImplementedException();
        }

        public IList<Party> GetBotParties()
        {
            throw new NotImplementedException();
        }

        public Party GetConnectedCounterpart(Party partyWhoseCounterpartToFind)
        {
            throw new NotImplementedException();
        }

        public IList<Party> GetPendingRequests()
        {
            throw new NotImplementedException();
        }

        public IList<Party> GetUserParties()
        {
            throw new NotImplementedException();
        }

        public bool IsAssociatedWithAggregation(Party party)
        {
            throw new NotImplementedException();
        }

        public bool IsConnected(Party party, ConnectionProfile connectionProfile)
        {
            throw new NotImplementedException();
        }

        public bool RemoveAggregationParty(Party party)
        {
            throw new NotImplementedException();
        }

        public IList<MessageRouterResult> Disconnect(Party party, ConnectionProfile connectionProfile)
        {
            throw new NotImplementedException();
        }

        public IList<MessageRouterResult> RemoveParty(Party partyToRemove)
        {
            throw new NotImplementedException();
        }

        public bool RemovePendingRequest(Party party)
        {
            throw new NotImplementedException();
        }

        public string ResolveBotNameInConversation(Party party)
        {
            throw new NotImplementedException();
        }

#if DEBUG
        public string GetLastMessageRouterResults()
        {
            throw new NotImplementedException();
        }

        public void AddMessageRouterResult(MessageRouterResult result)
        {
            throw new NotImplementedException();
        }
#endif
    }
}