using System.Linq;

namespace CodingChallenge.FamilyTree
{
    public class Solution
    {
        //Write a method that, given the person Ted(person) and the string 'Joe'(descendantName) are passed in, will return Joe's birth month.
        public string GetBirthMonth(Person person, string descendantName)
        {
            // THIS WAY WORKS BUT NOT REUSABLE
            //var kids = person.Descendants;
            //var grandKids = new List<Person>();

            ////GETS LIST OF KIDS AND GRANDKIDS OF TED
            //foreach (var kid in kids)
            //  list of grandKids has range of kids kids added to list
            //grandKids.AddRange(kid.Descendants);

            //// based on any descendantName input
            //switch (descendantName)
            //{
            //    case "Joe":
            //        return grandKids.FirstOrDefault(y => y.Name == descendantName).Birthday.ToString("MMMM");
            //        break;

            //    case "Ted":
            //        return person.Birthday.ToString("MMMM");
            //        break;

            //    default:
            //        return "";
            //        break;
            //}
            //return "No person exists";


            //if (person.Name == descendantName)
            //{
            //    return person.Birthday.ToString("MMMM");
            //}


            foreach (var currentPerson in person.Descendants)
            {
                if (currentPerson == person.Descendants.FirstOrDefault(x => x.Name == descendantName))
                    if (currentPerson != null)
                        return currentPerson.Birthday.ToString("MMMM");

                if (currentPerson != person.Descendants.FirstOrDefault(x => x.Name == descendantName))
                    return person.Birthday.ToString("MMMM");
                return GetBirthMonth(currentPerson, descendantName);
            }
            return GetParentBirth();
        }

        public static string GetParentBirth()
        {
            var person = new Person();
            return person.Birthday.ToString("MMMM");
        }
    }
}
