using List_OperatorOverLoading.Models;
using System.Collections;

#region Operator Overloading
Employee employee1 = new Employee()
{
    Id = 1,
    Name = "Chinara",
    Age = 22,
};
Employee employee2 = new Employee()
{
    Id = 2,
    Name = "Konul",
    Age = 26
};

var res = employee1 < employee2;
//Console.WriteLine(res);
#endregion

//Collections
#region Hashtable
Hashtable hashtable = new Hashtable();
hashtable.Add(1, "Chinara");
hashtable.Add(2, "Konul");
hashtable.Add(3, "Roya");

foreach (DictionaryEntry item in hashtable)
{
    //Console.WriteLine($"{item.Key} {item.Value}");
    if ((int)item.Key == 1)
    {
        //Console.WriteLine(item.Value);
    }
}
#endregion

#region ArrayList
ArrayList arrayList = new ArrayList();
arrayList.Add(1);
arrayList.Add(true);
arrayList.Add("Chinara");

foreach (var item in arrayList)
{
    //Console.WriteLine(item);
}
#endregion

#region SortedList
//non-generic
SortedList sortedList = new SortedList();
sortedList.Add(1, "Chinara");
sortedList.Add(2, "Gullu");
sortedList.Add(3, "Roya");

foreach (DictionaryEntry item in sortedList)
{
    //Console.WriteLine(item.Key);
}

//generic
SortedList<int, string> datas = new();
datas.Add(1, "Chinara");
datas.Add(2, "Gullu");

foreach (KeyValuePair<int, string> item in datas)
{
    //Console.WriteLine($"{item.Key} {item.Value}");
}
#endregion

#region Stack Queue
//Stack<int> stack = new Stack<int>();
//stack.Push(1);
//stack.Push(2);
//stack.Push(3);
//foreach (var item in stack)
//{
//    //Console.WriteLine(item);
//}

//Queue<int> queue = new Queue<int>();
//queue.Enqueue(1);
//queue.Enqueue(2);
//queue.Enqueue(3);

//foreach (var item in queue)
//{
//    //Console.WriteLine(item);
//}
#endregion

#region List
List<int> nums = new List<int>();
nums.Add(10);
nums.Add(2);
nums.Add(3);
//nums.Sort();
//nums.Reverse();
//var result = nums.Contains(1);
//Console.WriteLine(result);
//nums.Remove(3);
//nums.RemoveAt(2);
//nums.Clear();
//nums.RemoveAll(x => x > 5);
//var result = nums.Find(x => x.Equals(2));
//Console.WriteLine(result);
//var result=nums.FindAll(x=>x.Equals(10)).Count;
//Console.WriteLine(result);
//var result = nums.Sum();
//var result = nums.FindAll(x => x % 2 == 0).Sum();
//Console.WriteLine(result);
foreach (var item in nums)
{
    //Console.WriteLine(item);
}

List<string> names = new List<string>();
names.Add("Chinara");
names.Add("Roya");
names.Add("Konul");

//Console.WriteLine(names.Count);
//for (int i = 0; i < names.Count; i++)
//{
//    Console.WriteLine(names[i]);
//}

//foreach (var item in names)
//{
//    if (item.Equals("Chinara"))
//    {
//        Console.WriteLine(item);
//    }
//}
//var result1 = names.Find(x=>x.Equals("Chinara"));
//Console.WriteLine(result1);
//var result1 = names.FindAll(x => x.Equals("Chinara")).Count;
//Console.WriteLine(result1);

//List<Student> students = new List<Student>();
//List<Student> students2 = new List<Student>();
//students2.Add(new Student
//{
//    Id = 1,
//    Fullname = "Chinara Ibadova",
//    Address = "Lokbatan",
//    Age = 22
//});
//students.Add(new Student
//{
//    Id = 1,
//    Fullname = "Chinara Ibadova",
//    Address = "Lokbatan",
//    Age = 22
//});
//students.Add(new Student
//{
//    Id = 2,
//    Fullname = "Gullu Ibadova",
//    Address = "Lokbatan",
//    Age = 30
//});
//students.Add(new Student
//{
//    Id = 3,
//    Fullname = "Nermin Ibadova",
//    Address = "Lokbatan",
//    Age = 23
//});
//students.Add(new Student
//{
//    Id = 4,
//    Fullname = "Roya Meherremova",
//    Address = "Sumqayit",
//    Age = 26
//});
//students.Add(new Student
//{
//    Id = 5,
//    Fullname = "Konul Ibrahimova",
//    Address = "Nesimi",
//    Age = 26
//});

//students.AddRange(students2);

//foreach (var item in students)
//{
//    Console.WriteLine(item.Fullname);
//}
//AddStudent(new Student
//{
//    Id = 1,
//    Fullname = "Chinara Ibadova",
//    Address = "Lokbatan",
//    Age = 22
//});
static void AddStudent(Student student)
{
    List<Student> students = new();
    students.Add(student);
    foreach (var item in students)
    {
        Console.WriteLine($"{item.Fullname} {item.Age} ");
    }
}

static List<Student> GetStudents()
{
    List<Student> students = new List<Student>();

    students.Add(new Student
    {
        Id = 1,
        Fullname = "Chinara Ibadova",
        Address = "Lokbatan",
        Age = 22
    });
    students.Add(new Student
    {
        Id = 2,
        Fullname = "Gullu Ibadova",
        Address = "Lokbatan",
        Age = 30
    });
    students.Add(new Student
    {
        Id = 3,
        Fullname = "Nermin Ibadova",
        Address = "Lokbatan",
        Age = 23
    });
    students.Add(new Student
    {
        Id = 4,
        Fullname = "Roya Meherremova",
        Address = "Sumqayit",
        Age = 26
    });
    students.Add(new Student
    {
        Id = 5,
        Fullname = "Konul Ibrahimova",
        Address = "Nesimi",
        Age = 26
    });
    return students;
}

//Console.WriteLine("Enter a fullname");
//string fullName = Console.ReadLine();

//Console.WriteLine("Enter age");
//int age =int.Parse(Console.ReadLine());

//Student student = new Student()
//{
//    Id = 1,
//    Fullname = fullName,
//    Age = age
//};
//AddStudent(student);
//Console.WriteLine(GetStudentsCountByAges());
static int GetStudentsCountByAges()
{
    List<Student> students = GetStudents();
    var result = students.FindAll(st => st.Age > 26).Sum(a => a.Age);
    return result;
}


#endregion

#region HashSet
//HashSet<int> numbers = new();
//numbers.Add(1);
//numbers.Add(1);
//numbers.Add(2);
//numbers.Add(2);
//foreach (var item in numbers)
//{
//    //Console.WriteLine(item);
//}
#endregion

#region Dictionary
Dictionary<int, string> datas2 = new();

datas2.Add(4, "Chinara");
datas2.Add(5, "Roya");
datas2.Add(6, "Konul");

foreach (KeyValuePair<int,string> item in datas2)
{
    //Console.WriteLine($"{item.Key} {item.Value}");
}
#endregion

#region LinkedList
LinkedList<int> ints = new LinkedList<int>();
ints.AddFirst(1);
ints.AddFirst(2);
ints.AddFirst(3);
ints.AddLast(4);
var result = ints.Find(3);
//Console.WriteLine(result?.Next?.Value);

foreach (var item in ints)
{
    //Console.WriteLine(item);

}
#endregion
