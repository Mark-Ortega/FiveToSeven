using FiveToSeven.Services.MadLib;
using Microsoft.AspNetCore.Mvc;

namespace FiveToSeven.Controllers;

    [ApiController]
    [Route("MadLib")]
    public class MadLibController : ControllerBase
    {
        private readonly IMadLibServices _madLibServices;
        public MadLibController(IMadLibServices madLibServices)
        {
            _madLibServices = madLibServices;
        }

        [HttpGet]
        [Route("MadLib/{adverb1}/{name}/{verb1}/{storeName}/{verb2}/{gender}/{adverb2}/{creature}/{verb3}/{animalSpecies}")]
        
            public string MadLib(string adverb1, string name, string verb1, string storeName, string verb2, string gender, string adverb2, string creature, string verb3, string animalSpecies)
            {
                return _madLibServices.MadLib(adverb1, name, verb1, storeName, verb2, gender, adverb2, creature, verb3, animalSpecies);
            }
        
    }
