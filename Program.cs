// See https://aka.ms/new-console-template for more information
using Pillars_OOPS;
Console.WriteLine("Hello, World!");

//Shape<string> shape = new Shape<string>();
//shape.ShapeName="Circle"; // Assigning a value to the shapeName property
//Console.WriteLine($"Shape Name: {shape.ShapeName}");



//Rectangle rec = new Rectangle(8.0,6.0);
//Shape<Rectangle> shape = new Shape<Rectangle>(rec);//assigning a Rectangle object to the Shape class
//Console.WriteLine(shape.ShapeName); // Displaying the Rectangle object using its ToString method

GenericQueueDemo();
static void GenericQueueDemo()
{
    // Create an instance of GenericQueue for Person objects
    GenericQueue<Person> personQueue = new GenericQueue<Person>();
    // Adding Person objects to the queue
    Console.WriteLine("Enter number of persons to add to the queue:");
    int count = Convert.ToInt32(Console.ReadLine());
    for (int i = 0; i < count; i++)
    {
        Console.WriteLine($"Enter details for Person {i + 1}:");
        Console.WriteLine("Enter ID:");
        int id = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Name:");
        string? name = Console.ReadLine();
        Console.WriteLine("Enter Email:");
        string? email = Console.ReadLine();
        // Create a new Person object
        Person person = new Person(id, name, email);
        personQueue.EnqueueItem(person);
    }
    // Displaying the queue contents
    personQueue.DisplayQueue();
    // Dequeuing a Person object from the queue
    Console.WriteLine("Dequeuing a person from the queue:");
    personQueue.DequeueItem(); // here we are dequeuing the first person added to the queue
    // Displaying the queue contents after dequeuing
    personQueue.DisplayQueue();
}

//GenericStackDemo();
static void GenericStackDemo()
{
    // Create an instance of GenericStack for Person objects
    GenericStack<Person> personStack = new GenericStack<Person>();
    // Adding Person objects to the stack
    Console.WriteLine("Enter number of persons to add to the stack:");
    int count = Convert.ToInt32(Console.ReadLine());
    for (int i = 0; i < count; i++)
    {
        Console.WriteLine($"Enter details for Person {i + 1}:");
        Console.WriteLine("Enter ID:");
        int id = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Name:");
        string? name = Console.ReadLine();
        Console.WriteLine("Enter Email:");
        string? email = Console.ReadLine();
        // Create a new Person object
        Person person = new Person(id, name, email);
        personStack.PushItem(person);
    }
    // Displaying the stack contents
    personStack.DisplayStack();
    // Popping a Person object from the stack
    Console.WriteLine("Popping a person from the stack:");
    personStack.PopItem();//here we are popping the last person added to the stack
    // Displaying the stack contents after popping
    personStack.DisplayStack();
}


//GenDictionary();
// Demonstrating Generic Dictionary
static void GenDictionary()
{
    GenericDictionary<int, string> genericDictionary = new GenericDictionary<int, string>();
    // Adding key-value pairs to the dictionary
    genericDictionary.Add(1, "One");
    genericDictionary.Add(2, "Two");
    genericDictionary.Add(3, "Three");
    genericDictionary.Add(4, "Four");
    genericDictionary.Add(5, "Five");
    // Displaying the dictionary contents
    genericDictionary.DisplayDict();
    // Removing a key-value pair from the dictionary
    Console.WriteLine("Enter a key to remove from the dictionary:");
    int keyToRemove = Convert.ToInt32(Console.ReadLine());
    genericDictionary.Remove(keyToRemove);
    // Displaying the dictionary contents after removal
    genericDictionary.DisplayDict();

}


//GenericCollectionDemo();
static void GenericCollectionDemo()
{
    // Create an instance of GenericCollection
    GenericCollection genericCollection = new GenericCollection();
    // Adding numbers to the collection
    Console.WriteLine("Enter numbers to add to the collection :");
    int count = Convert.ToInt32(Console.ReadLine());
    for (int i = 0; i < count; i++)
    {
        Console.WriteLine($"Enter number {i + 1}:");
        int number = Convert.ToInt32(Console.ReadLine());
        genericCollection.AddNumbers(number);
    }
    genericCollection.displayNumbers();

    //removing numbers from the collection
    Console.WriteLine("Enter a number to remove from the collection:");
    int numberToRemove = Convert.ToInt32(Console.ReadLine());
    genericCollection.removeNumber(numberToRemove);
    genericCollection.displayNumbers();
    genericCollection.clearNumbers();
    genericCollection.displayNumbers();

    Console.WriteLine("Enter number of names to add to the collection :");
    int nameCount = Convert.ToInt32(Console.ReadLine());
    for (int i = 0; i < nameCount; i++)
    {
        Console.WriteLine($"Enter name {i + 1}:");
        string name = Console.ReadLine();
        genericCollection.AddName(name);
    }
    genericCollection.displayNames();
    Console.WriteLine("Enter a name to remove from the collection:");
    string nametoRemove = Console.ReadLine();
    genericCollection.removeName(nametoRemove);
    genericCollection.displayNames();
    genericCollection.clearNames();
    genericCollection.displayNames();

    // Adding Person objects to the collection
    Console.WriteLine("Enter the number of persons to add to the collection:");
    int personCount = Convert.ToInt32(Console.ReadLine());
    for (int i = 0; i < personCount; i++)
    {
        Console.WriteLine($"Enter details for Person {i + 1}:");
        Console.WriteLine("Enter ID:");
        int id = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Name:");
        string? name = Console.ReadLine();
        Console.WriteLine("Enter Email:");
        string? email = Console.ReadLine();
        // Create a new Person object
        Person person = new Person(id, name, email);
        genericCollection.AddPerson(person);
    }
    // Displaying Person objects in the collection
    Console.WriteLine("Persons in the collection:");
    foreach (var person in genericCollection.persons)
    {
        person.DisplayDetails();
        Console.WriteLine(person.GetPersonInfo());
    }
    //removing a Person object from the collection
    Console.WriteLine("Enter ID of the person to remove from the collection:");
    int personIdToRemove = Convert.ToInt32(Console.ReadLine());
    var personToRemove = genericCollection.persons.FirstOrDefault(p => p.Id == personIdToRemove);
    if (personToRemove != null)
    {
        genericCollection.persons.Remove(personToRemove);
        Console.WriteLine($"Person with ID {personIdToRemove} removed from the collection.");
    }
    else
    {
        Console.WriteLine($"Person with ID {personIdToRemove} not found in the collection.");
    }
    // Displaying remaining Person objects
    Console.WriteLine("Remaining Persons in the collection:");
    foreach (var person in genericCollection.persons)
    {
        person.DisplayDetails();
        Console.WriteLine(person.GetPersonInfo());
    }
    // Clear all Person objects from the collection
    genericCollection.persons.Clear();
    Console.WriteLine("All persons cleared from the collection.");
    Console.WriteLine("Generic Collection Demo completed.");
}



//InterfaceDemo();
//interface concept of multiple inheritance

static void InterfaceDemo()
{
    // Create an instance of TechnoPerson
    TechnoPerson technoPerson = new TechnoPerson();
    Console.WriteLine("Enter your ID:");
    technoPerson.Id = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Please enter your Name:");
    technoPerson.Name = Console.ReadLine();
    Console.WriteLine("Please enter your Email:");
    technoPerson.Email = Console.ReadLine();
    Console.WriteLine("Please enter your Entrepreneur ID:");
    technoPerson.EntroprenurId = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Please enter your Business Name:");
    technoPerson.BusinessName = Console.ReadLine();
    Console.WriteLine("Please enter your Business Type:");
    technoPerson.BusinessType = Console.ReadLine();
    Console.WriteLine("Please enter your Investment Amount:");
    technoPerson.InvestmentAmount = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Please enter your Years in Business:");
    technoPerson.YearsInBusiness = Convert.ToInt32(Console.ReadLine());
    technoPerson.DisplayEntroprenurDetails();
    Console.WriteLine($"Entrepreneur Info: {technoPerson.GetEntroprenurInfo()}");
}