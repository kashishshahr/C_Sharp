using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumsPractice
{
    class EnumPractice
    {
        public static Gender gender { get; set; }
        static void EnumMain(string[] args)
        {
            
            gender = Gender.Female;
            Console.WriteLine(GetGender(gender));

            //System.IO.FileShare.ReadWrite
            //System.IO.FileShare.Delete
            //System.IO.FileShare.Read

        }
        public static string GetGender(Gender id)
        {
            switch (id)
            {
                case Gender.Unknown:
                    return "Unknown";
                case Gender.Male:
                    return "Male";
                case Gender.Female:
                    return "Female";
                default:
                    return "Invalid";
            }
        }
    public enum Gender
    {
        Unknown, Male, Female
    }
    }
    class EnumPractice1
    {
        #region Commented
        //Strongly TYPED COnstant
        //Gender g=(Gender)2
        //int unl=(int)Gender.Uknown;
        //public enum  Gender:byte OR short
        //{
        //    Unknown,Male,Female
        //}
        //public static Gender
        //    gender { get; set; }
        //static void Main(string[] args)
        //{
        //    foreach(byte x in Enum.GetValues(typeof(Gender)))
        //    {
        //        Console.WriteLine(x);
        //    }
        //}
        #endregion 
    }
}
