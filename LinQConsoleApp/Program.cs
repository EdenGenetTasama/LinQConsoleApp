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

//Person[] arrayOfPersons = new Person[] { new Person("Edenio" , "Tasama" , 1996 ),
//new Person("Ross", "Geler", 2010),
//new Person("Daniel", "Tal", 2018),
//new Person("Monica", "Geler", 1996),
//};

//List<Person> listOfPerson = arrayOfPersons.Where(item => item.name.Length > 4).OrderBy(item => item.yearOfBirth).ToList();
//Person objThatRepeat = listOfPerson.Find(item => item.yearOfBirth == 1996);
//Console.WriteLine(objThatRepeat.name);

//foreach (Person person in listOfPerson)
//{
//    Console.WriteLine($"{person.name} , {person.yearOfBirth}");
//}

//1 : 

string[] namesArray = new string[5] { "Eden", "Daniel", "Ross", "Febi", "avi" };

List <string> listOfNames = namesArray.Where(item => item.ToUpper()[0] == 'A').ToList();

//foreach(string name in listOfNames)
//{
//    Console.WriteLine(name);
//}

//2 : 

int [] arrayOfAges = new int[10] {20,14,25,69,87,12,10,8,40,80};

List<int> listOfAges = arrayOfAges.Where(item=> item> 18).ToList();

//foreach (int age in listOfAges)
//{
//    Console.WriteLine(age);
//}

//3:

List <User> listOfUsers = new List<User> {
  new User("Edenio" , "Tasama" , 25 ),
new User("Ros", "Geler", 50),
new User("Daniel", "Tal", 90),
new User("Monica", "Geler", 10),
};

//List<User> afterLinqList = listOfUsers.Where(item => item.age > 21 ).ToList();

//foreach(User age in afterLinqList)
//{
//    Console.WriteLine(age.age);

//}


//4:
List<User> afterLinqListOver4Lenger = listOfUsers.Where(item=> item.name.Length > 4).ToList();

//foreach(User user in afterLinqListOver4Lenger)
//{
//    Console.WriteLine(user.name);
//}


//5

