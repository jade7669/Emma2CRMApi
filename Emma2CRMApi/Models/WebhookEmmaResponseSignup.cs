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
    public class WebhookEmmaResponseSignup : WebhookEmmaItem
    {
        [DataMember(Name = "data")]
        public MessageSignupData WebhookData { get; set; }
    }

    [Serializable]
    [DataContract]
    public class MessageSignupData : Data
    {
        [DataMember(Name = "member_id")]
        public string MemberId { get; set; }
    }
}
