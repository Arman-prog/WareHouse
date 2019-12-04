using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Pahest.Models
{
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Unit { get; set; }
        private double count;
        private decimal price;
        [DataType(DataType.Date)]
        public DateTime ReceivedDate { get; set; }
        private decimal cost;

      
      
        public double Count
        {
            get=>count;
            
            set
            {
                if (Price != 0)
                {
                    SetCost();
                }
                count = value;
            }

        }
        public decimal Price
        {
            get => price;
            set
            {
                if (Count != 0)
                {
                    SetCost();
                }
                price = value;
            }

        }

        public decimal Cost
        {
            get => cost;
            set
            {
                cost = SetCost();
            }
        }

        public decimal SetCost()
        {
            if (Price != 0 && Count != 0)
            {
                return Price * (decimal)Count;
            }
            return 0;
        }

    }
}
