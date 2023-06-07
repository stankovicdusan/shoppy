using Application.DataTransfer.Mail;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Api.Controllers
{
    [Route("api/mail")]
    [ApiController]
    public class MailController : Controller
    {
        [HttpPost] 
        public IActionResult Post([FromBody] SendMailDto dto)
        {
            string from = "dusan@outlook.com"; 
            MailMessage message = new MailMessage(from, dto.To);

            string mailbody = "Testni body email-a";
            message.Subject = "Testni subject email-a";
            message.Body = mailbody;
            message.BodyEncoding = Encoding.UTF8;
            message.IsBodyHtml = true;
            SmtpClient client = new SmtpClient("smtp.office365.com", 587);  
            System.Net.NetworkCredential basicCredential1 = new
            System.Net.NetworkCredential("dusan@outlook.com", "dusan2021#"); 
            client.EnableSsl = true;
            client.UseDefaultCredentials = false;
            client.Credentials = basicCredential1;
            try
            {
                client.Send(message);
            }

            catch (Exception ex)
            {
                throw ex;
            }

            return Ok("we send the mail thank you veri mach");
        }
    }
}
