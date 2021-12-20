using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace monastery_app.Models
{
    public class Todoes : ModelAbstract
    {
        public Todoes()
        {

        }

        public override int Id { get; set; } = 0;

        public int IdUser { get; set; }
        public int IdTask { get; set; }
        public string TodoStatus { get; set; }

        [JsonIgnore]
        public override string Path { get; set; } = "Todoes";
    }
}
