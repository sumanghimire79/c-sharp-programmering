namespace CollectionHWw1Day5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region exercise 1

            //a
            Console.WriteLine("---------1a-----");
            List<string> friendlist = new List<string>();
            friendlist.Add("Michael");
            friendlist.Add("Jonny");
            friendlist.Add("Lasse");
            friendlist.Add("Lasemin");
            friendlist.Add("Jonathan");
            friendlist.Add("Mich");
            friendlist.Add("Brian");
            friendlist.Add("Michail");
            friendlist.Add("Josepine");
            friendlist.Add("Suman");
            friendlist.Sort();

            foreach (var friend in friendlist)
            {
                Console.WriteLine(friend);
            }
            //b
            Console.WriteLine("---------1b-----");
            List<string> SwimminghobbyList = new List<string> { " swimming is healthy", "swimming is fun", " smimming makes man slim", "swimming makes man fresh" };
            foreach (var hobby in SwimminghobbyList)
            {
                Console.WriteLine($" hobby : ---{hobby}");
            }
            #endregion

            #region exercise 2
            //a
            Console.WriteLine("---------2a-----");
            List<string> dinnerList = new List<string> { "Lasse", "Brian", "Lasse" };
            foreach (var friendforDinner in dinnerList)
            {

                Console.WriteLine($"hey, {friendforDinner} i would like to invie you for dinner !!!");

            }
            //b
            Console.WriteLine("---------2b-----");
            dinnerList[2] = "suman";

            foreach (var friendforDinner in dinnerList)
            {
                Console.WriteLine($"hey, {friendforDinner} i would like to invie you for dinner !!!");
            }

            //c
            Console.WriteLine("---------2c-----");
            dinnerList.Add("Ram");
            dinnerList.Add("Chanda");
            dinnerList.Add("Robin");

            foreach (var friendforDinner in dinnerList)

            {
                Console.WriteLine($"hey, {friendforDinner} i would like to invie you for dinner !!!");
            }

            //d
            Console.WriteLine("---------2d-----");
            dinnerList.RemoveAt(dinnerList.Count - 1);
            dinnerList.RemoveAt(dinnerList.Count - 1);
            dinnerList.RemoveAt(dinnerList.Count - 1);
            foreach (var friendforDinner in dinnerList)


            {
                Console.WriteLine($"hey, {friendforDinner} i would like to invie you for dinner !!!");
            }
            #endregion

            #region exercise 3: Dictionaries

            //a
            Console.WriteLine("---------3a-----");
            Dictionary<string, string> personsInfo = new Dictionary<string, string>();
            personsInfo.Add("name", "Lasse");
            personsInfo.Add("age", "44");
            personsInfo.Add("shower per week", "7");

            foreach (var person in personsInfo)
            {
                Console.WriteLine($"{person.Key}:{person.Value}");

            }

            //b
            Console.WriteLine("---------3b-----");
            Dictionary<string, int> favouriteNumberList = new Dictionary<string, int>();

            favouriteNumberList.Add("suman", 33);
            favouriteNumberList.Add("Chanda", 55);
            favouriteNumberList.Add("Aayusma", 11);
            favouriteNumberList.Add("Ram", 171);
            foreach (var favouriteNumber in favouriteNumberList)
            {
                if (favouriteNumber.Value < 100)
                {

                    Console.WriteLine(favouriteNumber.Key);
                }
            }


            //C
            Console.WriteLine("---------3c-----");

            Dictionary<string, string> glossary = new Dictionary<string, string>();
            glossary.Add("c#", " This is popular language in backend programing in denmark");
            glossary.Add("JS", " JS is popular frontend language that changes the behaviour of a web page");
            glossary.Add("CSS", " CSS means casceding stylesheet language");

            foreach (var words in glossary)
            {
                Console.WriteLine($" \n {words.Key} - means: {words.Value}");
            }

            Console.ReadLine();

            #endregion
        }
    }
}