using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Diagnostics;

namespace CityInfo.API.Services
{
    public class LocalMailService : IMailService
    {
        private string _mailTo = "testing@notarealaddress.com";
        private string _mailFrom = "noreply@anothernotrealaddress.com";

        public void Send(string subject, string message)
        {
            // dummy just outputting to debug window
            Debug.WriteLine($"Mail from {_mailFrom} to {_mailTo}, with Local Mail Service");
            Debug.WriteLine($"Subject: {subject}");
            Debug.WriteLine($"Message: {message}");
        }
    }
}
