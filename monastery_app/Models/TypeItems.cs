using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace monastery_app.Models
{
    public class TypeItems : ModelAbstract
    {
        public TypeItems()
        {

        }

        public override int Id { get; set; } = 0;

        public string TypeItemName { get; set; }

        [JsonIgnore]
        public override string Path { get; set; } = "TypeItems";
    }
}
