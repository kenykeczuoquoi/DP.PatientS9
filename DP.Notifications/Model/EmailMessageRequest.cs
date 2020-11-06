using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DP.Notifications.Model
{
    public class EmailMessageRequest
    {
        public string EmailAddress { get; set; }
        public string Subject { get; set; }
        public string Body { get; set;  }
        
    }
}
