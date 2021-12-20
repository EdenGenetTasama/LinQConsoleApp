using LinQConsoleApp;




//Random random = new Random();

//int counter = 0;
//int[] randomArray = new int[10];

//while (counter < 10)
//{
//    int randomNum = random.Next(1, 10);
//    randomArray[counter] = randomNum;
//    counter++;
//}


//List<int> list = randomArray.Where(item => item % 2 == 0).ToList();


//for (int i = 0; i < list.Count; i++)
//{
//    Console.WriteLine(list[i]);
//}

//List<int> listTwo = randomArray.Where(item => item < 4).OrderBy(item => item).ToList();
//for (int i = 0; i < listTwo.Count; i++)
//{
//    Console.WriteLine(listTwo[i]);
//}

//מערך של string 

//string[] namesArray = new string[5] { "Eden", "Shay", "Monica", "Rachel", "Ross" };

//List<string> namesList = namesArray.Where(item => item.Length > 4).OrderByDescending(item => item).ToList();

//for(int i = 0; i < namesList.Count; i++)
//{
//    Console.WriteLine(namesList[i]);
//}

// 4 אובייקטים : 

Person[] arrayOfPersons = new Person[] { new Person("Edenio" , "Tasama" , 1996 ),
new Person("Ross", "Geler", 2010),
new Person("Daniel", "Tal", 2018),
new Person("Monica", "Geler", 1996),
};

List<Person> listOfPerson = arrayOfPersons.Where(item => item.name.Length > 4).OrderBy(item => item.yearOfBirth).ToList();
Person objThatRepeat = listOfPerson.Find(item => item.yearOfBirth == 1996);
Console.WriteLine(objThatRepeat.name);

foreach (Person person in listOfPerson)
{
    Console.WriteLine($"{person.name} , {person.yearOfBirth}");
}




