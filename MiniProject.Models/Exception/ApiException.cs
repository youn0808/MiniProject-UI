using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

/*we have only one exception that catch everything.  whenever we catch exception in this application and our api
 * we are going to basically wrap it in this object and we can do whatever we want*/
namespace MiniProject.Models.Exception
{
    public class ApiException
    {
        public int StatusCode { get; set; }
        public string Message { get; set; }
        public override string ToString() //this turn into the json. 
        {
            return JsonConvert.SerializeObject(this);
        }

    }
}
