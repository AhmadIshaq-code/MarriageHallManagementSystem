using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MY_Class_Project.Models
{
    public class Booking
    {
        public int BId { get; set; }

        public DateTime BDate { get; set; }

        public string BTime { get; set; }

        public string CustName { get; set; }

        public int CustId { get; set; }

        public int Persons { get; set; }

        public string Dishes { get; set; }

        public string Drinks { get; set; }

        public int CostDrink { get; set; }

        public int CostFood { get; set; }

        public int OtherCharges { get; set; }

        public int GrdTotal { get; set; }

        public int Advance { get; set; }

        public int Balance { get; set; }
    }
}
