using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace monastery_app.Models
{
    public class Services : ModelAbstract
    {
        public Services()
        {

        }

        public override int Id { get; set; } = 0;

        public string ServiceName { get; set; }
        public string ServiceDescription { get; set; }

        [JsonIgnore]
        public override string Path { get; set; } = "Services";
    }
}
