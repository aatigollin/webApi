using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace webApi.Controllers
{
    public class ValuesController : ApiController
    {
        private readonly NLog.Logger _logger;

        public ValuesController()
        {
            _logger = NLog.LogManager.GetCurrentClassLogger();
        }

        // GET api/values
        public IEnumerable<string> Get()
        {
            _logger.Info("get values");
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            try
            {
                _logger.Info($"get value id = {id}");
                return "value";
            }
            catch(Exception ex)
            {
                _logger.Error(ex, "more message");
                return "";
            }
        }
    }
}
