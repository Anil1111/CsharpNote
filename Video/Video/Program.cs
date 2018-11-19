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
    interface IListable
    {
        string[] ColumnValues{ get; }
    }
    public partial class Program
    {
        static void Main(string[] args)
        {

            Console.ReadKey();
        }
    }
    public abstract class PdaItem
    {
        public virtual string Name { get; set; }
        public PdaItem(string name)
        {
            Name = name;
        }
    }
    class Contact : PdaItem, IListable
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public Contact(string firstName, string lastName, string address, string phone):base(null)
        {
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            Phone = phone;
        }
        public string[] ColumnValues
        {
            get
            {
                return new string[] { FirstName, LastName, Address, Phone };
            }
        }
        public static string[] Headers
        {
            get
            {
                return new string[]
                {
                    "FirstName","LastName   ",
                    "Phone      ",
                    "Address                    "
                };
            }
        }
    }
    class Publication:IListable
    {
        public Publication(string title, string author, int year)
        {
            Title = title;
            Author = author;
            Year = year;
        }
        public string Title { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }

        public string[] ColumnValues
        {
            get
            {
                return new string[] { Title, Author, Year.ToString() };
            }
        }
        public static string[] Headers
        {
            get
            {
                return new string[]
                {
                    "Title                          ",
                    "Author         ",
                    "Year"
                };
            }
        }
    }
    class ConsoleListControl
    {
        public static void List(string[] headers, IListable[] items)
        {
            int[] columnWidths = DisplayHeaders(headers);
            for (int count = 0; count < items.Length; count++)
            {
                string[] values = items[count].ColumnValues;
                DisplayItemRow(columnWidths, values);
            }
        }
        private static int[] DisplayHeaders(string[] headers)
        {

        }

        private static void DisplayItemRow(int[] columnWidths, string[] values)
        {

        }
    }
}