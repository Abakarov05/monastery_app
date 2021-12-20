using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace monastery_app.Models
{
    public class Stores : ModelAbstract
    {
        public Stores()
        {

        }

        public override int Id { get; set; } = 0;

        public string StoreItemName { get; set; }

        public int StoreItemAvailable { get; set; }

        [JsonIgnore]
        public override string Path { get; set; } = "Stores";
    }
}
