using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Emma2CRMWebhook.Models
{
    [Serializable]
    [DataContract]
    public class WebhookEmmaResponseClick : WebhookEmmaItem
    {
        [DataMember(Name = "data")]
        public MessageClickData WebhookData { get; set; }
    }

    [Serializable]
    [DataContract]
    public class MessageClickData : Data
    {
        [DataMember(Name = "member_id")]
        public string MemberId { get; set; }
        [DataMember(Name = "subject")]
        public string Subject { get; set; }
        [DataMember(Name = "timestamp")]
        public string Timestamp { get; set; }
        [DataMember(Name = "link_id")]
        public string LinkId { get; set; }
    }
}
