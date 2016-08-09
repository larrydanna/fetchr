using System.Collections.Generic;
using System.Net;
using System.Web.Script.Serialization;
using fetchr.Entities;

namespace fetchr.ServiceAccess
{
    public class AskServiceClient
    {
        public AskServiceClient()
        {
            //
            // Dev Box endpoint
            //
            //Address = "http://localhost:51767/api/ask";

            Address = "http://fetchrwebservices.azurewebsites.net/api/ask";
        }

        public List<Ask> Get()
        {
            List<Ask> retVal = new List<Ask>();

            using (var client = new WebClient())
            {
                var stream = client.DownloadString(Address);

                retVal = Deserialize<List<Ask>>(stream);
            }

            return retVal;
        }

        public string Address { get; private set; }

        private T Deserialize<T>(string json)
        {
            return new JavaScriptSerializer().Deserialize<T>(json);
        }

        private string Serialize<T>(T t)
        {
            return new JavaScriptSerializer().Serialize(t);
        }

        public void Save(Ask ask)
        {
            using (var client = new WebClient())
            {
                client.Headers["Content-Type"] = "application/json";
                client.UploadString($"{Address}/save", $"POST", Serialize(ask));
            }
        }
    }
}