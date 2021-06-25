using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class ExceptionPractice
    {
        public static void EPMain(string[] args)
        {
            Console.WriteLine("Hey");
            //string fileText=File.ReadAllText("E:/InternShip/c#/SI/C_Sharp/C_sharp_concepts/MoreAboutCSharp/SampleFiles/Data.txt");
            //Console.WriteLine(fileText);

            //------------------------------------------------------------------------------------------------

            //StreamReader streamReader = new StreamReader("E:/InternShip/c#/SI/C_Sharp/C_sharp_concepts/MoreAboutCSharp/SampleFiles/Data.txt");
            //StreamReader streamReader = new StreamReader(@"E:\InternShip\c#\SI\C_Sharp\C_sharp_concepts\MoreAboutCSharp\SampleFiles\Data.txt");
            //Console.WriteLine(streamReader.ReadToEnd());
            //Console.WriteLine(streamReader.ReadToEndAsync().Result);

            //------------------------------------------------------------------------------------------------

            //If file gets deleted we need EXCeption Handling
            //StreamReader streamReader = new StreamReader(@"E:\InternShip\c#\SI\C_Sharp\C_sharp_concepts\MoreAboutCSharp
            //                                                \SampleFiles\Dat.txt");
            ////error on this line --> System.IO.IOException: 'The filename, directory name, or volume label syntax is incorrect
            //and as ERROR occurs  STREAM reader close line will not be executed and thus resources NEVER RELEASED.thus EXCEPTION HANDLING
            //Console.WriteLine(streamReader.ReadToEnd());

            //streamReader.Close();
            //------------------------------------------------------------------------------------------------

            //System.Exception Class has EXCEPTION  in c sharp
            //use try catch

            StreamReader streamReader = null;
            try
            {
                streamReader = new StreamReader(@"E:\InternShip\c#\SI\C_Sharp\C_sharp_concepts\MoreAboutCSharp"
                                                           + @"\SampleFiles\Data.txt");
                Console.WriteLine(streamReader.ReadToEnd());
                streamReader.Close();
            }
            catch (FileNotFoundException e)
            {
                //Console.WriteLine("Catched FILENOTFOUNDException\n" + e.Message);
                ////Console.WriteLine("NOT FOUND:\n" + e.FileName);
                //Console.WriteLine("\n\n" + e.StackTrace);
                Console.WriteLine("Please Check if File {0} exists", e.FileName);
            }
            catch (DirectoryNotFoundException e)
            {

                Console.WriteLine("Please Check if Directory Path is right \n" + e.Message);
            }
            catch (IOException e)
            {
                Console.WriteLine("Catched IOException\n" + e.Message);
                Console.WriteLine("\n\n" + e.StackTrace);
            }
            catch (Exception e)
            {
                Console.WriteLine("Catched Exception\n" + e.Message);
            }
            //catch
            //{
            //    Console.WriteLine("Catched Exception");
            //}
            finally
            {
                if (streamReader != null)
                { streamReader.Close(); }
                Console.WriteLine("Finally Block");
                //finally block needed bcz even if error occurs in catch block...THIS executes no matter what
            }


            Console.Read();
        }
    }
    class InnerException
    {
        static void InnerExceptionMain(string[] args)
        {
            try
            {
                try
                {
                    Console.WriteLine("Enter First Number:");

                    int FN = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter Second Number:");
                    int SN = Convert.ToInt32(Console.ReadLine());
                    int RN = FN / SN;
                    Console.WriteLine(@"{0} is the result of {1}/{2}", RN, FN, SN);
                }
                catch (Exception e)
                {
                    string filePath = @"E:\InternShip\c#\SI\C_Sharp\C_sharp_concepts\MoreAboutCSharp\ampleFiles\Log.txt";
                    if (File.Exists(filePath))
                    {
                        StreamWriter streamWriter = new StreamWriter(filePath);
                        streamWriter.Write(e.GetType().Name);
                        streamWriter.WriteLine();
                        streamWriter.Write(e.Message);

                        streamWriter.Close();
                    }
                    else
                    {
                        //throw new FileNotFoundException(filePath + " is not present", e);//passing e is to pass to INNNER ExCeption
                        throw new FileNotFoundException(filePath + " is not present", e);//passing e is to pass to INNNER ExCeption
                    }
                    Console.WriteLine("There is problem in INPUT");
                }
            }
            catch(Exception ex)
            {
                if(ex.InnerException!=null)
                    Console.WriteLine("There is error of " + ex.InnerException.GetType().FullName + " in inner block");
                Console.WriteLine("There is error of " + ex.GetType().FullName + "in Exception");
            }
            Console.Read();
        }

    }
    namespace CustomExceptionNS
    {
        class CustomException
        {
            static void CEXcMain(string[] args)
            {
                throw new UserAlreadyLoggedInException("User Already Logged In");
            }
        }
        [Serializable ]
        public class UserAlreadyLoggedInException:Exception
        {
            public UserAlreadyLoggedInException():base()
            {

            }
            public UserAlreadyLoggedInException(string message):base(message){
            }
            public UserAlreadyLoggedInException(string message,Exception inner):base(message,inner){
            }
            public UserAlreadyLoggedInException(SerializationInfo info,StreamingContext context):base(info,context){
            }
        }
    }

}
///use bool b=int.TryParse(Console.REad(),out Numerator);
// 
