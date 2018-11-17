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
            Employee employee1 = new Employee("zhu", "shuai", "Too Little");
            Console.WriteLine(employee1.Salary);
            
            
                            
            Console.ReadKey();
        }
    }
    class Employee
    {
        public Employee() { }
        public Employee(string firstName, string latsName, string salary)
        {
            FirstName = firstName;
            LastName = latsName;
            Salary = salary;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Salary { get; set; } = "Not enough";
        private string PassWord = "123456";
        private bool IsAutenticated = false;
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