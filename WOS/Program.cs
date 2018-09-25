using System;
using System.Collections.Generic;
using System.Linq;

namespace WOS
{
    class Program
    {
        static void Week1Problem1()
        {
            Console.WriteLine("Week 1 Problem 1");
            Console.WriteLine("Hello World!");
            Console.WriteLine();
        }

        static void Week1Problem2()
        {
            Console.WriteLine("Week 1 Problem 2");
            Console.WriteLine(5.0 / 24.0);
            Console.WriteLine();
        }

        static void Week1Problem3()
        {
            Console.WriteLine("Week 1 Problem 3");
            Console.Write("Enter a number: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter another number: ");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("{0} + {1} = {2}", num1, num2, num1 + num2);
            Console.WriteLine("{0} - {1} = {2}", num1, num2, num1 - num2);
            Console.WriteLine("{0} × {1} = {2}", num1, num2, num1 * num2);
            Console.WriteLine("{0} ÷ {1} = {2}", num1, num2, num1 / num2);
            Console.WriteLine("{0} mod {1} = {2}", num1, num2, num1 % num2);
            Console.WriteLine();
        }

        static void Week1Problem4()
        {
            Console.WriteLine("Enter four numbers.");
            Console.Write("First Number: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Second Number: ");
            int num2 = int.Parse(Console.ReadLine());
            Console.Write("Third Number: ");
            int num3 = int.Parse(Console.ReadLine());
            Console.Write("Fourth Number: ");
            int num4 = int.Parse(Console.ReadLine());
            double average = ((double)num1 + (double)num2 + (double)num3 + (double)num4) / 4.0;
            Console.WriteLine("The average is {0}.", average);
            Console.WriteLine();
        }

        static void Week1Problem5()
        {
            Console.Write("Enter a positive or negative integer: ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("The number is " + (num >= 0 ? "positive." : "negative."));
            Console.WriteLine();
        }

        static void Week1Problem6()
        {
            int amountOfPositives = 0;
            Console.WriteLine("Enter a positive or negative integer: ");
            if (int.Parse(Console.ReadLine()) >= 0) amountOfPositives++;
            Console.WriteLine("Enter another integer: ");
            if (int.Parse(Console.ReadLine()) >= 0) amountOfPositives++;
            Console.WriteLine("Amount of Positives: {0}", amountOfPositives);
            Console.WriteLine();
        }

        static void Week1Problem7()
        {
            Console.WriteLine("Enter an integer: ");
            int num = int.Parse(Console.ReadLine());
            if (num % 3 == 0 && num % 5 == 0) Console.WriteLine("fizz buzz");
            else if (num % 3 == 0) Console.WriteLine("fizz");
            else if (num % 5 == 0) Console.WriteLine("buzz");
            Console.WriteLine();
        }

        static void Week1Problem8()
        {
            int[] array = new int[3];
            Console.WriteLine("Enter three integers.");
            Console.Write("1: ");
            array[0] = int.Parse(Console.ReadLine());
            Console.Write("2: ");
            array[1] = int.Parse(Console.ReadLine());
            Console.Write("3: ");
            array[2] = int.Parse(Console.ReadLine());
            Console.WriteLine("Largest number: {0}", array.Max());
        }

        static void Week1Problem9()
        {
            Console.Write("Enter a grade (an integer between 0 and 100 inclusive): ");
            int grade = int.Parse(Console.ReadLine());
            if (grade >= 90) Console.WriteLine("A");
            else if (grade >= 80) Console.WriteLine("B");
            else if (grade >= 70) Console.WriteLine("C");
            else if (grade >= 60) Console.WriteLine("D");
            else Console.WriteLine("F");
            Console.WriteLine();
        }

        static void Week1Problem10()
        {
            Console.Write("Enter an integer: ");
            int num = int.Parse(Console.ReadLine());
            if (num > 0)
            {
                for (int i = 0; i <= num; i++)
                {
                    Console.WriteLine(i);
                }
            }
            else if (num < 0)
            {
                for (int i = 0; i >= num; i--)
                {
                    Console.WriteLine(i);
                }
            }
            else
            {
                Console.WriteLine(0);
            }
            Console.WriteLine();
        }

        static void Week1Problem11()
        {
            Console.Write("Enter a character: ");
            char character = char.Parse(Console.ReadLine());
            Console.Write("Enter the desired width: ");
            int width = int.Parse(Console.ReadLine());
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Console.Write(character);
                }
                Console.Write("\n");
            }
            Console.WriteLine();
        }

        static void Week1Problem12()
        {
            Console.WriteLine("Enter a positive integer: ");
            int num = int.Parse(Console.ReadLine());
            for (int i = 1; i <= num; i++)
            {
                if (i % 2 == 1) Console.Write("{0} ", i);
            }
            Console.Write("\n");
            Console.WriteLine();
        }

        static void Week1Problem13()
        {
            Console.WriteLine("Enter a positive integer: ");
            int num = int.Parse(Console.ReadLine());
            for (int i = num; i > 0; i--)
            {
                string str = "";
                if (i % 3 == 0) str += "fizz\n";
                if (i % 5 == 0) str += "buzz\n";
                if (str == "") str = i.ToString() + "\n";
                Console.Write(str);
            }
            Console.WriteLine();
        }

        static void Week1Problem14(int[] arr)
        {
            Console.WriteLine(arr.Sum());
        }

        static void Week1Problem15(int[] arr)
        {
            for (int i = 1; i < arr.Length; i += 2)
            {
                Console.Write("{0} ", arr[i]);
            }
        }

        static void Week1Problem16(int[] arr)
        {
            if (arr.Length % 2 != 0)
            {
                Console.WriteLine("Error: Length of input array is not even.");
                return;
            }

            int len = arr.Length / 2;
            if (arr.Take(len).Sum() == arr.Skip(len).Take(len).Sum()) Console.WriteLine("true");
            else Console.WriteLine("false");
        }

        static int Week2Problem1(int a, int b)
        {
            return a + b;
        }

        static bool Week2Problem2(string a, string b)
        {
            return a == b;
        }

        static void Week2Problem3(string name)
        {
            Console.WriteLine("Hello " + name);
        }

        static int Week2Problem4(int[] arr)
        {
            return arr.Sum();
        }

        static string Week2Problem5(string str, int num, char letter)
        {
            if (num > str.Length - 1) return "Error: Index out of range.";

            return str.Substring(0, num) + letter + str.Substring(num + 1);

        }

        static int Week2Problem6(int a, int b)
        {
            return (int)Math.Pow(a, b);
        }

        static int Week2Problem7(int[] arr)
        {
            return arr.Max();
        }

        private static void WashTheAnimal(Animal a)
        {
            a.Dirty = false;
            Console.WriteLine(a.Name + " is clean");
        }

        static void Main(string[] args)
        {
            Week1Problem1();
            Week1Problem2();
            Week1Problem3();
            Week1Problem4();
            Week1Problem5();
            Week1Problem6();
            Week1Problem7();
            Week1Problem8();
            Week1Problem9();
            Week1Problem10();
            Week1Problem11();
            Week1Problem12();
            Week1Problem13();
            //Week1Problem14(numbers);
            int[] numbers2 = { 1, 4, 2, 6, 5, 8 };
            //Week1Problem15(numbers2);
            int[] array = { 1, 2, 3, 2, 2, 2 };
            //Week1Problem16(array);

            // Week 2 Problem 1
            int number = Week2Problem1(2, 3);
            Console.WriteLine(number);

            // Week 2 Problem 2
            string s1 = "hello";
            string s2 = "hello";
            Console.WriteLine(Week2Problem2(s1, s2));
            string s3 = "world";
            string s4 = "World";
            Console.WriteLine(Week2Problem2(s3, s4));

            // Week 2 Problem 3
            string name = "Dave";
            Week2Problem3(name);

            // Week 2 Problem 4
            //Console.WriteLine(Week2Problem4(numbers));

            // Week 2 Problem 5
            Console.WriteLine(Week2Problem5("Hello", 1, 'a'));

            // Week 2 Problem 6
            Console.WriteLine(Week2Problem6(2, 3));

            // Week 2 Problem 7
            int[] numbers3 = { 24, 13, 27, 8 };
            Console.WriteLine(Week2Problem7(numbers3));

            // Week 2 Problem 8
            Person p1 = new Person();
            p1.Name = "Frank";
            p1.Age = 30;
            p1.Gender = "Male";
            p1.Birthday();
            Console.WriteLine(p1.Age);

            // Week 2 Problem 9
            Vehicle v1 = new Vehicle();
            //v1.Make = "Ford";
            v1.Make = VehicleMake.Ford;
            v1.Model = "T";
            v1.Color = "Brown";
            v1.Miles = 1000m;
            v1.Year = 1925;
            Console.WriteLine(v1.IsNew());  //Should print out false;
            v1.Drive(100);
            Console.WriteLine(v1.Miles); //Should print out 1100;

            // Week 2 Problem 10
            Point a = new Point(22.5m, -6.2m);
            Point b = new Point(0.0m, 10m);
            decimal calculatedDistance = a.Distance(b);
            Console.WriteLine(calculatedDistance);

            // Week 2 Problem 11
            Employee a1 = new Employee("Sally", new DateTime(1972, 3, 15), "CEO", 120000m);
            Employee b1 = new Employee("Bill", new DateTime(1981, 1, 16));
            Employee c1 = new Employee();
            Console.WriteLine(Employee.Count);  //Should print 3 

            // Week 2 Problem 11
            Car c2 = new Car();
            c2.Color = "Yellow";
            Truck t = new Truck();
            t.Miles = 100;

            // Week 2 Problem 11
            Dog d = new Dog("Harry");
            d.Dirty = true;
            Cat c3 = new Cat("Larry");
            c3.Dirty = true;
            WashTheAnimal(d);
            WashTheAnimal(c3);

            // Week 2 Problem 11
            CheckingAccount leesChecking = new CheckingAccount("12345", "Lee", 500m);
            SavingsAccount leesSavings = new SavingsAccount("54321", "Lee", 1000m);
            leesChecking.Withdraw(100m);
            Console.WriteLine(leesChecking.Balance);
            leesChecking.Withdraw(600m);
            Console.WriteLine(leesChecking.Balance);
            leesSavings.Deposit(100m);
            leesSavings.AddInterest();
            leesSavings.Withdraw(200m);
            Console.WriteLine(leesSavings.Balance);

            // Week 3 Problem 1
            ns1.Person person1 = new ns1.Person();
            ns2.Person person2 = new ns2.Person();
            person1.Print();
            person2.Print();

            // Week 3 Problem 2
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee("Rick", new DateTime(1981, 1, 16), "Software Engineer", 65000m));
            employees.Add(new Employee("Tina", new DateTime(1978, 7, 4), "Senior Software Engineer", 85000m));
            employees.Add(new Employee("Chris", new DateTime(1993, 2, 13), "Associate Software Engineer", 55000m));
            employees.Add(new Employee("Mindy", new DateTime(1996, 8, 3), "Chief Technology Officer", 155000m));

            foreach (Employee employee in employees)
            {
                Console.WriteLine(employee.Dispense());
            }

            employees[2].Promote(10000m, "Software Engineer");   //But this does

            // Week 3 Problem 3
            //Console.WriteLine("Enter your score");
            //string input = Console.ReadLine();
            //int grade = int.Parse(input);
            //int leadingDigit = grade / 10;

            //switch (leadingDigit)
            //{
            //    case 10:
            //        Console.WriteLine("A");
            //        break;
            //    case 9:
            //        Console.WriteLine("A");
            //        break;
            //    case 8:
            //        Console.WriteLine("B");
            //        break;
            //    case 7:
            //        Console.WriteLine("C");
            //        break;
            //    case 6:
            //        Console.WriteLine("D");
            //        break;
            //    default:
            //        Console.WriteLine("F");
            //        break;
            //}

            // Week 3 Problem 4
            Vehicle v2 = new Vehicle();
            v2.Make = VehicleMake.Ford;
            v2.Model = "T";
            v2.Color = "Brown";
            v2.Miles = 1000m;
            v2.Year = 1925;

            // Week 3 Problem 5
            try
            {
                Console.WriteLine("Enter a number");
                int x = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter another number");
                int y = int.Parse(Console.ReadLine());
                Console.WriteLine("{0} + {1} = {2}", x, y, x + y);
                Console.WriteLine("{0} - {1} = {2}", x, y, x - y);
                Console.WriteLine("{0} * {1} = {2}", x, y, x * y);
                Console.WriteLine("{0} / {1} = {2}", x, y, x / y);
                Console.WriteLine("{0} mod {1} = {2}", x, y, x % y);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


            Console.WriteLine("Press Enter to exit.");
            Console.ReadLine();

            // Week 3 Problem 6

        }
    }

    class Person
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }

        public void Birthday()
        {
            Age++;
        }
    }

    class Vehicle
    {
        public VehicleMake Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }
        public decimal Miles { get; set; }

        public void Drive(decimal miles)
        {
            Miles += miles;
        }

        public bool IsNew()
        {
            return Year == DateTime.Now.Year;
        }
    }

    public enum VehicleMake
    {
        GM,
        Ford,
        Lincoln,
        Chrysler,
        Cadillac,
        Jeep,
        Tesla,
        Nissan,
        Mitsubishi,
        Infiniti,
        Honda,
        Toyota,
        MercedesBenz,
        Audi,
        BMW,
        Volkswagen
    }

    class Car : Vehicle
    {

    }

    class Truck : Vehicle
    {

    }

    class Point
    {
        public decimal X;
        public decimal Y;

        public Point(decimal x, decimal y)
        {
            X = x;
            Y = y;
        }

        public decimal Distance(Point p)
        {
            return (decimal)Math.Sqrt(Math.Pow((double)(p.X - X), 2.0) + Math.Pow((double)(p.Y - Y), 2.0));
        }
    }

    class Employee
    {
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string JobTitle { get; set; }
        private decimal Salary { get; set; }
        public static int Count { get; set; }

        public Employee()
        {
            Name = "";
            JobTitle = "";
            Salary = -1;
            DateOfBirth = DateTime.Now;
            Count++;
        }

        public Employee(string name, DateTime dateOfBirth)
        {
            Name = name;
            DateOfBirth = dateOfBirth;
            Count++;
        }

        public Employee(string name, DateTime dateOfBirth, string jobTitle, decimal salary)
        {
            Name = name;
            DateOfBirth = dateOfBirth;
            JobTitle = jobTitle;
            Salary = salary;
            Count++;
        }

        public decimal Dispense()
        {
            return Salary / 26;
        }

        public void Promote(decimal additionalPay, string newJobTitle)
        {
            Salary += additionalPay;
            JobTitle = newJobTitle;
        }
    }

    class Animal
    {
        public string Name { get; set; }
        public bool Dirty { get; set; }

        public Animal(string name)
        {
            Name = name;
        }

        public string Speak()
        {
            return "";
        }
    }

    class Dog : Animal
    {
        public Dog(string name) : base(name) { }
    }

    class Cat : Animal
    {
        public Cat(string name) : base(name) { }
    }

    class BankAccount
    {
        public string AccountNumber { get; set; }
        public string Owner { get; set; }
        public decimal Balance { get; set; }

        public BankAccount(string accountNumber, string owner, decimal balance)
        {
            AccountNumber = accountNumber;
            Owner = owner;
            Balance = balance;
        }

        public BankAccount(string accountNumber, string owner)
        {
            AccountNumber = accountNumber;
            Owner = owner;
        }

        public virtual void Withdraw(decimal amount)
        {
            Balance -= amount;
        }

        public virtual void Deposit(decimal amount)
        {
            Balance += amount;
        }

        public virtual void AddInterest() { }
    }

    class CheckingAccount : BankAccount
    {
        public CheckingAccount(string accountNumber, string owner, decimal balance) : base(accountNumber, owner, balance) { }

        public CheckingAccount(string accountNumber, string owner) : base(accountNumber, owner) { }

        public override void Withdraw(decimal amount)
        {
            if (amount > Balance)
            {
                Console.WriteLine("Error: Insufficient funds.");
                return;
            }
            else
            {
                Balance -= amount;
            }
        }
    }

    class SavingsAccount : BankAccount
    {
        public SavingsAccount(string accountNumber, string owner, decimal balance) : base(accountNumber, owner, balance) { }

        public SavingsAccount(string accountNumber, string owner) : base(accountNumber, owner) { }

        public override void Withdraw(decimal amount)
        {
            if (amount > (Balance * 0.10m))
            {
                Console.WriteLine("Error: Maximum withdrawal amount exceeded.");
                return;
            }
            else if (amount > Balance)
            {
                Console.WriteLine("Error: Insufficient funds.");
                return;
            }
            else
            {
                Balance -= amount;
            }
        }

        public override void AddInterest()
        {
            Balance += Balance * 0.002m;
        }
    }

    public class Rectangle
    {
        //The underscore is a "style guideline"
        //but has no effect on how this compiles or runs.
        private double _length;
        private double _width;

        public Rectangle(double length, double width)
        {
            _length = length;
            _width = width;
        }

        public double Perimeter
        {
            get
            {
                // return 0;   //This isn't correct
                return (_length * 2) + (_width * 2);
            }

        }

        public double Area
        {
            get
            {
                // return 0;   //Neither is this
                return _length * _width;
            }
        }
    }
}

namespace ns1
{
    class Person
    {
        public void Print()
        {
            Console.WriteLine("I am from ns1");
        }
    }
}

namespace ns2
{
    class Person
    {
        public void Print()
        {
            Console.WriteLine("I am from ns2");
        }
    }
}