using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace monastery_app.Models
{
    public class Tasks : ModelAbstract
    {
        public Tasks()
        {

        }

        public override int Id { get; set; } = 0;

        public string TaskName { get; set; }
        public int IdTypeTask { get; set; }

        [JsonIgnore]
        public override string Path { get; set; } = "Tasks";
    }
}
