using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Pipes;
using System.Runtime.Serialization.Json;
using System.Web.Http;
using fetchr.Entities;
using WebServices.DataLayer;

namespace WebServices.Controllers
{
    public class AskController : ApiController
    {
        [HttpGet]
        public List<Ask> GetAll()
        {
            return AskDb.Instance.Get();
        }

        [HttpPost]
        public void Save([FromBody]Ask ask)
        {
            AskDb.Instance.Save(ask);
        }
    }
}