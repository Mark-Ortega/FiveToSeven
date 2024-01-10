
using FiveToSeven.Services.ReverseItNum;
using Microsoft.AspNetCore.Mvc;

namespace FiveToSeven.Controllers;

[ApiController]
[Route("ReverseItNum")]
    public class ReverseItNumController
    {
        private readonly IReverseItNumServices _reverseItNumServices;

        public ReverseItNumController(IReverseItNumServices reverseItNumServices)
        {
            _reverseItNumServices = reverseItNumServices;
        }

        [HttpGet]
        [Route("ReversedNum")]

        public string ReverseItNum(string input)
        {
            return _reverseItNumServices.ReverseItNum(input);
        }
    }
