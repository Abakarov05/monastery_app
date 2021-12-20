using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace monastery_app.Models
{
    public class Budgets : ModelAbstract
    {
        public Budgets()
        {

        }

        public override int Id { get; set; } = 0;

        public int IdNotePrice { get; set; }
        public int IdOfferItemPrice { get; set; }
        public DateTime BudgetDate { get; set; }

        [JsonIgnore]
        public override string Path { get; set; } = "Budgets";
    }
}
