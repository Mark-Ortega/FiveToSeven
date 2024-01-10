
namespace FiveToSeven.Services.MadLib;
    public class MadLibServices : IMadLibServices
    {
        public string MadLib(string adverb1, string name, string verb1, string storeName, string verb2, string gender, string adverb2, string creature, string verb3, string animalSpecies)
        {
            return $"a {adverb1} person named {name} One day {verb1} at {storeName} Then {name} proceeded to start {verb2} and as {gender} was {verb2} Every one stared, laughing and pointing until out of no where a(n) {adverb2} {creature} Came {verb3} into the {storeName} the {creature} started wreaking havok in {storeName} and freed all the {animalSpecies} Why would there be {animalSpecies} in the {storeName} you may ask? i have no clue. ask the {storeName} manager. Now everday {name} is {verb2} they think back on that day.";
        }
    }
