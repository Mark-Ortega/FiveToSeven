
using FiveToSeven.Services.OddOrEven;
using Microsoft.AspNetCore.Mvc;

namespace FiveToSeven.Controllers;

[ApiController]
[Route("OddOrEven")]
    public class OddOrEvenController
    {
        private readonly IOddOrEvenServices _oddOrEvenServices;
        public OddOrEvenController(IOddOrEvenServices oddOrEvenServices)
        {
            _oddOrEvenServices = oddOrEvenServices;
        }

        [HttpGet]
        [Route("OddOrEven")]

        public string OddOrEven(int num)
        {
            return _oddOrEvenServices.OddOrEven(num);
        }
    }
