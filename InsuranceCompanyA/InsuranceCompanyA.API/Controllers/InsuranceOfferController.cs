using InsuranceCompanyA.API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InsuranceCompanyA.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class InsuranceOfferController : ControllerBase
    {
        private readonly ILogger<InsuranceOfferController> _logger;

        public InsuranceOfferController(ILogger<InsuranceOfferController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public OfferModel Get([FromBody] CarInsuranceModel model)
        {
            if (model is null) throw new ArgumentNullException("Request is not valid.");
            var vmodel = new OfferModel()
            {
                Name = "Anadolu Sigorta",
                OfferDescription = "Zorunlu Trafik Sigortası",
                LogoUrl = "http://cdnsnet.mncdn.com/static/images/shared/firmLogos/anadolusigorta.png",
                Fee = new Random().Next(100, 3000),
                LicencePlate = model.LicencePlate
            };
            return vmodel;
        }

    }
}
