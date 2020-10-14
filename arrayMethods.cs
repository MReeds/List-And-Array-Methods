using System.Linq;

// ...

List<int> numbers = new List<int>() { 100, 32, 98, 4, 1, 22, 73, 8 };
List<int> small = numbers.Where(n => n < 10).ToList();
List<int> even = numbers.Where(n => n % 2 == 0).ToList();

List<string> words = new List<string>() { "do", "you", "understand", "the", "words", "coming", "out", "of", "my", "mouth?" };
List<string> yelling = words.Select(w => w.ToUpper());
string sentence = string.Join(" ", yelling);

List<Person> people = GetPeopleFromSomeplace();
List<string> names = people.Select(p => p.Name).ToList();
Person person = people.First(p => p.Name == "Selam");
bool isAnyoneNamedPhil = people.Any(p => p, Name == "Phil");
bool doesEveryoneHaveAHobby = people.All(p => p.Hobbies.Count > 0);

// Try Catch

try
{
    int age = GetAgeFromSomeplace();
    if (age < 0)
    {
        throw new Exception("You can't be younger than zero, no matter how hard you try.");
    }
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}