using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace monastery_app.Models
{
    public class Salaries : ModelAbstract
    {
        public Salaries()
        {

        }

        public override int Id { get; set; } = 0;

        public int SalaryPrice { get; set; }
        public int IdUser { get; set; }

        [JsonIgnore]
        public override string Path { get; set; } = "Salaries";
    }
}
