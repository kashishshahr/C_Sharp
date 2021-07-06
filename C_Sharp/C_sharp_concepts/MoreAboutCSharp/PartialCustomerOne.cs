using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreAboutCSharp
{
    public partial class PartialCustomer
    {
        private string _firstName;
        private string _lastName;
        partial void SampleMethod()
        {
            Console.WriteLine("Full name:\n");
        }
        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }


        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }
        }
    }
