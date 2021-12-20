using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace monastery_app.Models
{
    public class Offers : ModelAbstract
    {
        public Offers()
        {

        }

        public override int Id { get; set; } = 0;
        public int IdUser { get; set; }
        public int IdItem { get; set; }
        public int IdOfferStatus { get; set; }
        public DateTime OfferDate { get; set; }

        [JsonIgnore]
        public override string Path { get; set; } = "Offers";
    }
}
