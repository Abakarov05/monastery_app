using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace monastery_app.Models
{
    public class Users : ModelAbstract
    {
        public Users()
        {

        }

        public override int Id { get; set; } = 0;

        public string UserName { get; set; }
        public string UserSurname { get; set; }
        public string UserLogin { get; set; }
        public string UserPassword { get; set; }
        public int IdRole { get; set; }
        public int IdDiscount { get; set; }

        [JsonIgnore]
        public override string Path { get; set; } = "Users";
    }
}
