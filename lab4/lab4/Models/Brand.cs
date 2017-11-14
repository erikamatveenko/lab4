using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab4.Models
{
    public partial class Brand
    {
        public Brand()
        {
            Cars = new HashSet<Car>();
        }

        public int BrandID { get; set; }
        public string BrandName { get; set; }
        public string BrandCompany { get; set; }
        public string BrandCountry { get; set; }
        public DateTime? BrandStartDate { get; set; }
        public DateTime? BrandEndingDate { get; set; }
        public string BrandCharacteristic { get; set; }
        public string BrandCategory { get; set; }
        public string BrandDescription { get; set; }

        public ICollection<Car> Cars { get; set; }
    }
}
