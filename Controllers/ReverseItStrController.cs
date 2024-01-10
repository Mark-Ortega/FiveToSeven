
using FiveToSeven.Services.ReverseItStr;
using Microsoft.AspNetCore.Mvc;

namespace FiveToSeven.Controllers;

[ApiController]
[Route("ReverseItString")]
    public class ReverseItStrController
    {
        private readonly IReverseItStrServices _reverseItStrServices;

        public ReverseItStrController(IReverseItStrServices reverseItStrServices)
        {
            _reverseItStrServices = reverseItStrServices;
        }

        [HttpGet]
        [Route("ReversedString")]

        public string ReverseItStr(string input)
        {
            return _reverseItStrServices.ReverseItStr(input);
        }
    }
