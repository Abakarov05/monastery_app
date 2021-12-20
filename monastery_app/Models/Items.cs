using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace monastery_app.Models
{
    public class Items : ModelAbstract
    {
        public Items()
        {

        }

        public override int Id { get; set; } = 0;
        public int IdStore { get; set; }
        public int IdType { get; set; }
        public int ItemPrice { get; set; }

        [JsonIgnore]
        public override string Path { get; set; } = "Items";
    }
}
