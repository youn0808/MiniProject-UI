using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* as services wehre we are going to upload*/
namespace MiniProject.Models.Settings
{
    public class CloudinaryOptions
    {
        public string CloudName { get; set; }
        public string ApiKey { get; set; }
        public string ApiSecret { get; set; }
    }
}
