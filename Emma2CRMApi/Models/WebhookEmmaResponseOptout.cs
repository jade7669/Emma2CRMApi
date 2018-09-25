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
    public class WebhookEmmaResponseOptout : WebhookEmmaItem
    {
        [DataMember(Name = "data")]
        public MessageOptOutData WebhookData { get; set; }
    }

    [Serializable]
    [DataContract]
    public class MessageOptOutData : Data
    {
        [DataMember(Name = "member_id")]
        public string MemberId { get; set; }
        [DataMember(Name = "subject")]
        public string Subject { get; set; }
        [DataMember(Name = "timestamp")]
        public string Timestamp { get; set; }
    }
}
