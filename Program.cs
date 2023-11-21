
//1. implicit va explicit haqida yozing

//	transformation

//	implicit 
//int a = 10;
//double b = a;


//explicit:
//double c = 10.5;
//int d = (int)a; // double dan int ga aniqli ravishda o'girish




//---------------------------------------------------

//2. | bilan & haqida yozing

//bool x1 = (5 > 6) | (4 < 6); // 5 > 6 - false, 4 < 6 - true,  true qaytadi
//bool x2 = (5 > 6) | (4 > 6); // 5 > 6 - false, 4 > 6 - false, false qaytadi

//& ikkilik sanoq sistemasida and
//	Возвращает true, если оба операнда одновременно равны true.

//	bool x1 = (5 > 6) &(4 < 6); // 5 > 6 - false, 4 < 6 - true, поэтому возвращается false
//bool x2 = (5 < 6) & (4 < 6); // 5 < 6 - true, 4 < 6 - true, поэтому возвращается true


//3 List bilan gagged arrayni nima farqi bor
// Add - element qushish
//var list = new List<int>();
//list.Add(5);

// Remove 
//list.Remove(5);
//Console.WriteLine(list[0]);
//if (list.Contains(5))
//{
//    Console.WriteLine(true);
//}



// 4 Abstraction hususiyati haqida yozing
// Abstraction bu biror projectimizni qanday qilib bizga natija qaytaryotganini yashirish.


//5 LinkedList, SortedList, Dictionary va HashTable haqida yozing


//LinkedList<int> linkedList = new LinkedList<int>();
//linkedList.AddLast(1);
//linkedList.AddLast(2);
//linkedList.AddLast(3);



//LinkedListNode<int> node = linkedList.Find(2);
//linkedList.AddAfter(node, 4); // Before

//foreach (int value in linkedList)
//{
//    Console.WriteLine(value);
//}

//var dict = new Dictionary<int, int>(); 
//var sortedList = new SortedList<int,int>();
//var hasTable = new Hashtable();



//6.Regex orqali berilgan matndan barcha raqamlarni va so'zda a harfi qatnashgan so'zlarni ajratib oling

//	muntazam iboralar

// werbattom

//Regex reg = new Regex(@"(\w*)a(\w*)");


//string str = " a 123a a1323";

//var rr = reg.Matches(str);
//foreach (Match match in rr)
//{
//    Console.WriteLine(match);
//}

//  (\w*) -Bu belgi harflarni ifodalaydi.
//		\w harflarni bildiradi.
//		* belgisi esa bir yoki bir nechta harflarni bildiradi.
//	a - Bu belgi "a" harfini belgilaydi.
// . = 1 talik belgi
// + = 1 ta va kuproq kelganda
// ? = 0 = 1
// /s =  ' '

//// 7 == bilan String.Equal() ni nima farqi bor // konkret
//string s1 = null;
//string s2 = null;
//bool usingOperator = s1 == s2; // Operator bilan solishtirish
//bool usingMethod = s1.Equals(s2); // Metod bilan solishtirish

// 8 .DriveInfo bilan DirectoryInfoni nima farqi bor.

//using System;
//using System.IO;

//class Program
//{
//    static void Main()
//    {
//        var drives = DriveInfo.GetDrives();

//        foreach (DriveInfo drive in drives)
//        {
//            Console.WriteLine($"Drive Name: {drive.Name}");
//            Console.WriteLine($"Total Size: {drive.TotalSize}");
//            Console.WriteLine($"Available Free Space: {drive.AvailableFreeSpace}");
//            Console.WriteLine($"Drive Format: {drive.DriveFormat}");
//            Console.WriteLine();
//        }
//    }
//}
//class Program
//{
//    static void Main()
//    {
//        var directory = new DirectoryInfo("C:\\Temp");

//        Console.WriteLine($"Directory Name: {directory.Name}");
//        Console.WriteLine($"Full Path: {directory.FullName}");
//    }
//}


//9.jsonplaceholder.com saytidan free api olib HttpClient orqali malumotlarni olib modelga o'zlashtiring

//using (HttpClient client = new HttpClient())
//{
//    var message = await client.GetAsync("https://jsonplaceholder.typicode.com/posts");
//    var json = await message.Content.ReadAsStringAsync();
//    var posts = JsonConvert.DeserializeObject<List<Post>>(json);
//        foreach (var i in posts)
//        {   
//            Console.WriteLine(i.id);
//        }
//}
//class Post
//{
//    public int userId { get; set; }
//    public int id { get; set; }
//    public string title { get; set; }
//    public string body { get; set; }
//}



//10 Asinxron bilan Sinxron programmingni nima farqi bor


//11 Polling va WebHook haqida yozing

