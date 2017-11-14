using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab4.Models
{
    public partial class Car
    {
        public int CarID { get; set; }
        public int? BrandID { get; set; }
        public int? OwnerID { get; set; }
        public int? CarRegistrationNumber { get; set; }
        public int? CarPhoto { get; set; }
        public int? CarNumberOfBody { get; set; }
        public int? CarNumberOfMotor { get; set; }
        public int? CarNumberOfPassport { get; set; }
        public DateTime? CarReleaseDate { get; set; }
        public DateTime? CarRegistrationDate { get; set; }
        public DateTime? CarLastCheckupDate { get; set; }
        public string CarColor { get; set; }
        public string CarDescription { get; set; }

        public Owner Owner { get; set; }
        public Brand Brand { get; set; }
    }
}