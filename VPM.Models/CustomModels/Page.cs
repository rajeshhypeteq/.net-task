﻿using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace VPM.Models.CustomModels
{
    /// <summary>
    /// 
    /// </summary>
    public class Page
    {
        /// <summary>
        /// 
        /// </summary>
        public Page()
        {
            Meta = new Meta();
            Result = new JArray();
        }
        
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "meta")]
        public Meta Meta { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "results")]
        public Object Result { get; set; }

    }
    
    /// <summary>
    /// 
    /// </summary>
    public class ConnectionPage
    {
        /// <summary>
        /// 
        /// </summary>
        public ConnectionPage()
        {
            Meta = new Meta();
            Result = new JArray();
        }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "meta")]
        public Meta Meta { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "results")]
        public Object Result { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "total_invitation_count")]
        public long totalInvitationCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "total_sent_count")]
        public long totalInvitationSentCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "total_receive_count")]
        public long totalInvitationReceiveCount { get; set; }



        [JsonProperty(PropertyName = "total_group_invitation_count")]
        public long totalGroupInvitationCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "total_group_sent_count")]
        public long totalGroupInvitationSentCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "total_group_receive_count")]
        public long totalGroupInvitationReceiveCount { get; set; }





        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "total_system_commission")]
        public float? totalsystemcommissionCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "total_agent_commission")]
        public float? totalagentcommissionCount { get; set; }


    }

    public class InviteSpResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "total_invitation_count")]
        public long totalInvitationCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "total_sent_count")]
        public long totalInvitationSentCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "total_receive_count")]
        public long totalInvitationReceiveCount { get; set; }
    }

    public class FinanceSpResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "total_system_commission")]
        public float? totalsystemcommissionCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "total_agent_commission")]
        public float? totalagentcommissionCount { get; set; }

     
    }

    public class MessageListPage
    {
        /// <summary>
        /// 
        /// </summary>
        public MessageListPage()
        {
            Meta = new Meta();
            Result = new JArray();
        }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "meta")]
        public Meta Meta { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "results")]
        public Object Result { get; set; }

        /// <summary>
        /// The bool that you assigned to mute a member in the channel.
        /// </summary>
        [JsonProperty("is_muted")]
        public bool isMuted { get; set; }

        /// <summary>
        /// The bool that you assigned to block a member in the channel.
        /// </summary>
        [JsonProperty("is_blocked")]
        public bool isBlocked { get; set; }

        /// <summary>
        /// The string that system assigned to identify the channel.
        /// </summary>
        [JsonProperty("channel_sid")]
        public string channelSid { get; set; }
    }
}