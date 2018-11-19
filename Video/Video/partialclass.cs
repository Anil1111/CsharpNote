using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Video
{
    public partial class Program
    {
        public class CommandLine
        {
            public CommandLine(string[] args)
            {
                for (int argumentCounter = 0; argumentCounter < args.Length; argumentCounter++)
                {
                    switch (argumentCounter)
                    {
                        case 0: Action = args[argumentCounter].ToLower(); break;
                        case 1: Id = args[argumentCounter].ToLower(); break;
                        case 2: FirstName = args[argumentCounter].ToLower(); break;
                        case 3: LastName = args[argumentCounter].ToLower(); break;
                        default: Console.WriteLine("error"); break;
                    }
                }
            }
            public string Action;
            public string Id;
            public string FirstName;
            public string LastName;
            public void Display()
            {
                Console.WriteLine($"Action={Action}\tId={Id}\tFirstName={FirstName}\tLastName={LastName}");
            }
        }
    }
}
