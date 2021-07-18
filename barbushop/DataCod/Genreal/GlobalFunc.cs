using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Threading.Tasks;
using System.Net;
using System.Collections.Specialized;
using System.Threading;

namespace barbushop
{
    namespace General
    {
        public class GlobalFunc
        {

            public static async Task SendSMSAsync(string number, string message, string fromWho = "")
            {
                HttpClient client = new HttpClient();
                //Define the Required Variables
                string key = "OPgnC61AB";
                string pass = "93667556";
                string user = "0545607333";
                string sender = "Barbushop";
                string recipient = number;
                string msg = message;
                msg += "/n"+fromWho;

                var values = new Dictionary<string, string>
            {
                { "key", key }, { "user", user },{ "pass", pass },
                { "sender", sender }, { "recipient", recipient },
                { "msg", msg }
            };
                var content = new FormUrlEncodedContent(values); //Encode the Data
                try
                {
                    var response = await client.PostAsync("https://www.sms4free.co.il/ApiSMS/SendSMS", content);
                    var responseString = await response.Content.ReadAsStringAsync();
                }
                catch(Exception e)
                {

                }
                
            }

        }

    }
    
}