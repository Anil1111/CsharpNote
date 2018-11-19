using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Video
{
    abstract class PDAItem
    {
        public virtual string Name { get; set; }
        protected abstract string GetSummary();
    }
    class Contact1 : PDAItem
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public override string Name
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
            set
            {
                string[] name = value.Split(' ');
                FirstName = name[0];
                LastName = name[1];
            }
        }
        protected override string GetSummary()
        {
            return $"FirstName:{FirstName} LastName:{LastName} Address:{Address}";
        }
    }
    class Appointment:PDAItem
    {
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }
        public string Location { get; set; }

        protected override string GetSummary()
        {
            return $"Name:{Name} Start:{StartDateTime} End:{EndDateTime} Location:{Location}";
        }
    }
}
