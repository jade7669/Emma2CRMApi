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
    public class WebhookEmmaItem
    {
        [DataMember(Name = "event_name")]
        public string WebhookEventName { get; set; }
    }

    [Serializable]
    [DataContract]
    public class Data
    {
        [DataMember(Name = "account_id")]
        public string AccountId { get; set; }
        [DataMember(Name = "mailing_id")]
        public string MailingId { get; set; }
    }

}
