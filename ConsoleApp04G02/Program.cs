using System.Diagnostics;
using System.Text;
using System.Threading.Channels;
using System.Transactions;

namespace ConsoleApp04G02;

internal class Program
{
    static void Main(string[] args)
    {

        #region Loops

        #region For Loop


        //for (int i = 1; i < 1000; i++)
        //{
        //    Console.WriteLine(i);
        //}

        //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        //for (int i = 0; i < numbers.Length; i++)
        //{
        //    if (numbers[i] % 2 == 1)
        //        numbers[i]++;
        //}

        //for (int i = 0; i < numbers.Length; i++)
        //{
        //    Console.WriteLine(numbers[i]);
        //}


        //O(1) => O Log(n) => O(n) => O(n^2)

        //for (int i = 1; i <= 12; i++)
        //{
        //    Console.WriteLine($"The {i} Multiblication Table");
        //    for(int j = 1; j <= 12; j++)
        //        Console.WriteLine($"{i} * {j} = {i * j}");
        //}






        #endregion

        #region While Loop
        //Console.WriteLine("Please Enter A Number");
        //bool b = int.TryParse(Console.ReadLine(), out int x);

        //while (!b)
        //{
        //    Console.WriteLine("Please Enter A Number");
        //    b = int.TryParse(Console.ReadLine(), out int y);
        //}

        #endregion

        #region Do While

        //bool flag;
        //do
        //{
        //    Console.WriteLine("Please Enter A Number");
        //    flag = int.TryParse(Console.ReadLine(), out int x);
        //} while (!flag);

        #endregion

        #region Foreach
        //IEnumerable


        //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        //foreach (int number in numbers)
        //{
        //    Console.WriteLine(number);
        //}


        #endregion

        #endregion

        #region Jump Statments

        //for (int i = 1; i <= 12; i++)
        //{

        //    if(i == 8)
        //    {
        //        //continue;
        //        //break;
        //    }
        //    Console.WriteLine($"The {i} Multiblication Table");

        //    for (int j = 1; j <= 12; j++)
        //        Console.WriteLine($"{i} * {j} = {i * j}");
        //}

        //Print(Console.ReadLine());

        //    int month = 3;

        //    switch (month)
        //    {
        //        case 1:
        //        case 2:
        //            Console.WriteLine("Winter");
        //            break;
        //        case 3:
        //            Console.Write("its ");
        //            goto case 2;
        //        default:

        //            break;
        //    }


        //int age = 50;
        //goto agePlus;

        //Console.WriteLine(age);


        //agePlus:
        //    Console.WriteLine(age + 5);



        #endregion

        #region String Imutability & String Interning

        //int x = 5; 
        //int y = x;

        //Console.WriteLine(y); // 5
        //x = 10;
        //Console.WriteLine(y); // 5


        //Student s1 = new Student() { Id = 1, Name = "Ali"};

        //Student s2 = s1;

        //Console.WriteLine(s2.Id); // 1
        //s1.Id = 2;
        //Console.WriteLine(s2.Id); // 2

        //string s1 = "Ali";

        //string s2 = s1;

        //Console.WriteLine(s2);
        //s1 = "Ammar";
        //Console.WriteLine(s2);


        //string s1 = "Ali";
        //string s2 = "Ali";
        //string s3 = new string("Ali");

        //Console.WriteLine(s1.Equals(s3));
        //Console.WriteLine(s1.GetHashCode());
        //Console.WriteLine(s3.GetHashCode());

        //Console.WriteLine(object.ReferenceEquals(s1, s3));


        #endregion

        #region String Builder

        //StringBuilder sb = new StringBuilder("A");
        //string s = "A";

        //Stopwatch stopwatch = new Stopwatch();
        //stopwatch.Start();

        //for (int i = 0; i < 100000; i++)
        //    s = s + "A";

        //stopwatch.Stop();
        //Console.WriteLine("Time For String");
        //Console.WriteLine(stopwatch.ElapsedMilliseconds);

        //Stopwatch stopwatch2 = new Stopwatch();
        //stopwatch2.Start();
        //for (int i = 0; i < 100000; i++)
        //    sb.Append("A");

        //stopwatch2.Stop();
        //Console.WriteLine("Time For StringBuilder");
        //Console.WriteLine(stopwatch2.ElapsedMilliseconds);

        //string str = sb.ToString();


        #endregion

        #region String Formating
        //C:\Users\LOQ\source\repos\Testable-Version
        //string superstring = """
        //    dfsdfsdf
        //    fdgdsfg
        //    sdfgdsfg
        //    dfgs
        //    """;



        //string path = @"C:\Users\LOQ\source\repos\Testable-Version";

        //int age = 40;
        //string s1 = "I'm", s2 = ", My Age Is";

        //string name = "Omar";

        //Console.WriteLine($"{s1} {name} {s2} {(age > 50 ? "Ali" : "Amr")}");

        //Console.WriteLine(s1 + " " + name + " " + s2 + " " + age);

        //Console.WriteLine(string.Format("I'm {0}, My age Is {1}", name, age));

        #endregion

        #region Session Task

        //Console.WriteLine("Please enter your name: ");
        //string name = Console.ReadLine();

        //Console.WriteLine("Please enter your age: ");
        //int.TryParse(Console.ReadLine(), out int age);

        //Console.WriteLine("Enter grade one: ");
        //int.TryParse(Console.ReadLine(), out int gradeOne);

        //Console.WriteLine("Enter grade two: ");
        //int.TryParse(Console.ReadLine(), out int gradeTwo);

        //Console.WriteLine("Enter grade three: ");
        //int.TryParse(Console.ReadLine(), out int gradeThree);

        //int total = gradeOne + gradeTwo + gradeThree;
        //double avg = total / 3;

        //string status = avg >= 50 ? "passed" : "failed";
        //Console.WriteLine(status);

        #endregion

    }

    static void Print(string s)
    {
        if (String.IsNullOrWhiteSpace(s))
        {
            Console.WriteLine("send another string");
            return;
        }
        Console.WriteLine(s);
    }
}
