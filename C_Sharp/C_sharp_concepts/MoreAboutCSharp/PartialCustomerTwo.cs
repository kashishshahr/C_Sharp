using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreAboutCSharp
{
    public partial class PartialCustomer
    {
        partial void SampleMethod();
        public string GetFullName()
        {
            SampleMethod();
            return _firstName + _lastName;
        }

    }
}
