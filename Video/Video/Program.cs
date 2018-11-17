using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;
using System.Collections;

namespace Video
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee.NextID = 10000;
            Console.WriteLine("*********************************");
            Employee employee = new Employee();

            Console.WriteLine(employee.GetFullInfo());
            Console.WriteLine(MyExtensionMethod.GetFullInfo(employee));

            Console.WriteLine(employee.PI);

            Console.ReadKey();
        }
    }
    class Employee
    {
        static Employee()
        {
            Console.WriteLine("static constructor!!!");
        }
        public Employee(string firstName="zhu", string lastName="shuai")
        {
            Initial(firstName, lastName);
        }
        private void Initial(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            ID = NextID;
            NextID++;
        }
        public readonly double PI = 3.1415926d;
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Salary { get; set; } = "Not enough";
        private string PassWord = "123456";
        private bool IsAutenticated = false;
        public int ID { get; set; }
        public static int NextID;
        public string GetName() => FirstName + " " + LastName;
        public void SetName(string newFirstName, string newLastName)
        {
            FirstName = newFirstName;
            LastName = newLastName;
            Console.WriteLine($"Name changed to '{GetName()}'");
        }
        public void Save()
        {
            DataStorage.Store(this);
        }
        public bool Logon(string passWord)
        {
            IsAutenticated = false;
            if (passWord == PassWord)
                IsAutenticated = true;
            return IsAutenticated;
        }
        public bool GetIsAutenticated()
        {
            return IsAutenticated;
        }
        public string name
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
            set
            {
                string[] names;
                names = value.Split(new char[] {' '});
                if (names.Length == 2)
                {
                    FirstName = names[0];
                    LastName = names[1];
                }
                else
                    throw new Exception();
            }
        }
        public string GetFullInfo()
        {
            string str = "InClassMethod";
            return $"{FirstName} {LastName}({ID}) {Salary} {str}";
        }
    }
    class DataStorage
    {
        public static void Store(Employee employee)
        {
            FileStream stream = new FileStream(employee.FirstName + employee.LastName + ".dat", FileMode.Create);
            StreamWriter writer = new StreamWriter(stream);

            writer.WriteLine(employee.FirstName);
            writer.WriteLine(employee.LastName);
            writer.WriteLine(employee.Salary);

            writer.Close();
        }

        public static Employee load(string filePath)
        {
            Employee employee = new Employee();

            FileStream stream = new FileStream(filePath, FileMode.Open);

            StreamReader reader = new StreamReader(stream);
            employee.FirstName = reader.ReadLine();
            employee.LastName = reader.ReadLine();
            employee.Salary = reader.ReadLine();

            reader.Close();

            return employee;
        }
    }
}