﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfo.API.Services
{
    public class CloudMailService : IMailService
    {
        private string _mailTo = "testing@notarealaddress.com";
        private string _mailFrom = "noreply@anothernotrealaddress.com";

        public void Send(string subject, string message)
        {
            // dummy just outputting to debug window
            Debug.WriteLine($"Mail from {_mailFrom} to {_mailTo}, with Cloud Mail Service");
            Debug.WriteLine($"Subject: {subject}");
            Debug.WriteLine($"Message: {message}");
        }
    }
}