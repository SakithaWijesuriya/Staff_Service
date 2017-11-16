using System;
using System.Configuration;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;

namespace StaffService.SMS
{
    class SMSGateway
    {
        public void sendSMS(string Amount, string to)
        {

            string accountSid = ConfigurationManager.AppSettings["twilioaccountSid"];
            string authToken = ConfigurationManager.AppSettings["twilioauthToken"];
            string phoneno = ConfigurationManager.AppSettings["twilioPhoneNumber"];
            TwilioClient.Init(accountSid, authToken);


            MessageResource.Create(
                to: new PhoneNumber(to),
                from: new PhoneNumber(phoneno),
                body: ConfigurationManager.AppSettings["SMSMessage '" + Amount + "'"]);
        }
    }
}
