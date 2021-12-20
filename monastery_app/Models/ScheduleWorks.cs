using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace monastery_app.Models
{
    public class ScheduleWorks : ModelAbstract
    {
        public ScheduleWorks()
        {

        }

        public override int Id { get; set; } = 0;

        public int IdService { get; set; }
        public DateTime ScheduleWorkDate { get; set; }

        [JsonIgnore]
        public override string Path { get; set; } = "ScheduleWorks";
    }
}
