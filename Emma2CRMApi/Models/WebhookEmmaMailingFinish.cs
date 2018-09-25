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
    public class WebhookEmmaMailingFinish : WebhookEmmaItem
    {
        [DataMember(Name = "data")]
        public MailingFinishData WebhookData { get; set; }
    }

    [Serializable]
    [DataContract]
    public class MailingFinishData : Data
    {
        [DataMember(Name = "subject")]
        public string Subject { get; set; }
        [DataMember(Name = "timestamp")]
        public string Timestamp { get; set; }
    }
}
