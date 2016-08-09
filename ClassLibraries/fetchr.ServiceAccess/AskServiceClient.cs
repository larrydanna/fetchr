using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Net;
using System.Web.Script.Serialization;
using fetchr.Entities;

namespace fetchr.ServiceAccess
{
    public class AskServiceClient
    {
        public AskServiceClient()
        {
            Address = "http://localhost:51767/api/ask";
        }

        public List<Ask> Get()
        {
            List<Ask> retVal = new List<Ask>();

            using (var client = new WebClient())
            {
                var stream = client.DownloadString(Address);

                retVal = Deserialize<List<Ask>>(stream);

                //DataContractJsonSerializer dataContractJsonSerializer = new DataContractJsonSerializer(typeof(List<Ask>));
                //var stream = client.OpenRead("http://localhost:51767/api/ask");
                //if (stream != null)
                //{
                //    retVal = (List<Ask>)dataContractJsonSerializer.ReadObject(stream);
                //}
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