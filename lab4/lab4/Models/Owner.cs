using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab4.Models
{
    public partial class Owner
    {
        public Owner()
        {
            Cars = new HashSet<Car>();
        }

        public int OwnerID { get; set; }
        public string OwnerName { get; set; }
        public DateTime? OwnerBirthDate { get; set; }
        public string OwnerAddress { get; set; }
        public string OwnerPassport { get; set; }
        public int? OwnerNumberOfDriverLicense { get; set; }
        public DateTime? OwnerLicenseDeliveryDate { get; set; }
        public DateTime? OwnerLicenseValidityDate { get; set; }
        public string OwnerCategory { get; set; }
        public string OwnerMoreInformation { get; set; }

        public ICollection<Car> Cars { get; set; }
    }
}