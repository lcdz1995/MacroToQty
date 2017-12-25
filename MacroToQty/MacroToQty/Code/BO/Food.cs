using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MacroToQty.Code
{
    class Food
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public int Calorie { get; set; }
        public int Carbs { get; set; }
        public int Protein { get; set; }
        public int Fat { get; set; }
        public int Quantity { get; set; }
        public bool IsUnit { get; set; }
    }
}
