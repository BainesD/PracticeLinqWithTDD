using LinqChallenge.Domain.Entities;
using System.Linq;

namespace LinqChallenge.Easy
{
    /// <summary>
    /// All tests for this class can be found in the following location:
    /// LinqChallenge.Tests.Easy.WhereChallengeTests
    /// </summary>
    public class WhereChallenge
    {
        /* GetPeopleOlderThanEighteen - Tests Details

            Below are the names of your tests - Have fun!

            Given_Null_Should_ReturnEmptyCollection
            Given_EmptyCollection_Should_ReturnEmptyCollection
            Given_PeopleWhereNoneAreOlderThanEighteen_Should_ReturnEmptyCollection
            Given_PeopleWhereSomeAreOlderThanEighteen_Should_ReturnOnlyPeopleOlderThanEighteen
        */
        public IEnumerable<Person> GetPeopleOlderThanEighteen(IEnumerable<Person> people)
        {
            if (people == null)
                return Enumerable.Empty<Person>();
            if (people.All(x=> x.Age < 18))
                return Enumerable.Empty<Person>();
            if (people.Any(x=> x.Age > 18))
                return people.Where(x=> x.Age > 18).ToList();
            return Enumerable.Empty<Person>();
        }
    }
}