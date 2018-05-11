﻿using Newtonsoft.Json;
using System;
using Underscore.Bot.MessageRouting.Models;

namespace Underscore.Bot.MessageRouting.Results
{
    /// <summary>
    /// The connection request result type:
    /// - OK: Connection request successfully created,
    /// - AlreadyRequested: A connection request for the requestor already exists,
    /// - NotSetup: No aggregation channel or portal available (no-one to accept/reject the request),
    /// - Rejected: The request was rejected,
    /// - Error: Generic error, see the error message.
    /// 
    /// Note: Accepted requests are provided with connection result instead of this class.
    /// </summary>
    public enum ConnectionRequestResultType
    {
        OK = 0,
        AlreadyRequested,
        NotSetup,
        Rejected,
        Error
    };

    [Serializable]
    public class ConnectionRequestResult : AbstractMessageRouterResult
    {
        public ConnectionRequestResultType Type
        {
            get;
            set;
        }

        /// <summary>
        /// The connection request associated with this result.
        /// </summary>
        public ConnectionRequest ConnectionRequest
        {
            get;
            set;
        }

        public ConnectionRequestResult() : base()
        {
        }

        public static ConnectionRequestResult FromJson(string resultAsJsonString)
        {
            ConnectionRequestResult connectionRequestResult = null;

            try
            {
                connectionRequestResult =
                    JsonConvert.DeserializeObject<ConnectionRequestResult>(resultAsJsonString);
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine($"Failed to deserialize from JSON: {e.Message}");
            }

            return connectionRequestResult;
        }

        public string ToJson()
        {
            return JsonConvert.SerializeObject(this);
        }

        public override string ToString()
        {
            return ToJson();
        }
    }
}
