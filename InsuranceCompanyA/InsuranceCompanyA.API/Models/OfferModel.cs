using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InsuranceCompanyA.API.Models
{
    public class OfferModel
    {
        public string Name { get; set; }
        public string LogoUrl { get; set; }
        public string OfferDescription { get; set; }
        public decimal Fee { get; set; }
        public string LicencePlate { get; set; }
    }
}
