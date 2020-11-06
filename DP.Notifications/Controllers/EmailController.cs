using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using DP.Notifications.Model;
using DP.Notifications.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DP.Notifications.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmailController : ControllerBase
    {
        [HttpPost]
        public void SendMessage(EmailMessageRequest request)
        {
            EmailSender sender = new EmailSender();

            sender.SendNewUserEmail(request.EmailAddress);
        }
    }
}
