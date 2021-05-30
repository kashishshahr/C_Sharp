using System;
using System.Collections.Generic;

namespace Q1
{
    //A Photo Studio provides many photo services, like, converting a set of photos to gray scale album.The
    //following code implements a class PhotoStudio which takes the order(through function PlaceOrder)
    //where it takes set of photos.And, then it can convert the photo set into gray scale.See the following
    //implementation:

    enum PhotoType { Jpeg, Png,Bmp };
    class Jpeg { } /* represents a JPEG file */
    class Filter
    {
        public T GrayScale<T>(T img) { /*convert to grayscale*/ return img; }
    }
    class Png { } /* represents a PNG file */
    class Bmp { } /* represents a BMP file */
 
    class PhotoStudio
    {
        private Filter filter;
        private List<Jpeg> jpegs;
        private List<Png> pngs;
        private List<Bmp> bmps;
        public void PlaceOrder(List<Jpeg> jpegPhotos, List<Png> pngPhotos, List<Bmp> bmpPhotos, PhotoType
       image)
        {
            switch (image)
            {
                case PhotoType.Jpeg:
                    filter = new Filter();
                    jpegs = jpegPhotos;
                    break;
                case PhotoType.Png:
                    filter = new Filter();
                    pngs = pngPhotos;
                    break;
                case PhotoType.Bmp:
                    filter = new Filter();
                    pngs = pngPhotos;
                    break;
            }
        }
        public List<Jpeg> GetGrayScaleAlbumForJpeg()
        {
            List<Jpeg> album = new List<Jpeg>();
            foreach (var photo in jpegs)
                album.Add(filter.GrayScale(photo));
            return album;
        }
        public List<Png> GetGrayScaleAlbumForPng()
        {
            List<Png> album = new List<Png>();
            foreach (var photo in pngs)
                album.Add(filter.GrayScale(photo));
            return album;
        }
    }
    //    There are several problems with the above implementation.For example, both gray scale conversion
    //functions do pretty much the same thing, other than working on different type of image format,
    //violating the DRY principle. Also, whole PhotoStudio class gets affected if new type of photo(like bmp) is
    //introduced.
    //Use guidance on SOLID principles and OOP concepts to come up with modified code that is a much
    //better design, while achieving the same purpose – to convert a set of photos into gray scale set.In your
    //answer re-write complete code.Goals of your solutions should be:
    //1. DRY principle is not violated i.e. there is only one function to process the album into gray scale
    //for any photo type
    //2. If 3rd type of photo is introduced in the system, nothing in class PhotoStudio changes other than
    //addition of switch case for the new type of photo in PlaceOrder function. (Don’t introduce a 3rd
    //type, only imagine and test where all your code changes)
    ///* your answer goes here */
}
namespace Q2
{
    //    Q2.
    //Following code simulates a visa approval for an applicant at an embassy.No change to the
    //code in class Applicant is allowed.
    //In class Embassy also, no change is allowed other than filling in blank.
    //You need to implement
    //callback or pub/sub mechanism in the
    //class VisaProcessor such that class
    //Embassy can utilize it.
    //In the VisaProcessor class that you author, you can assume that it approves the
    //visa for every applicant when its ProcessVisa method is called – and it informs the registered entities
    //about the status in this call itself via calling the callback function set by the entity (Embassy here).
    //Complete the code so that when it is run, the output is exactly the following:
    //    Applicant ID: 1, Status: Approved
    //Applicant ID: 2, Status: Approved

    class Applicant
    {
        public Applicant(int ID) { this.ID = ID; }
        public int ID { get; }
    }
    class VisaProcessor
    {
        public delegate void Called();
        public void SetCallbackForVisaStatus(Called called)
        {
            called();
        }
        public void ProcessVisa(Applicant a)
        {

        }
    }
    class Embassy
    {
        public static void Q2Main(string[] args)
        {
            List<Applicant> applicants = new List<Applicant>()
 { new Applicant(1), new Applicant(2)};
            VisaProcessor visaProcessor = new VisaProcessor();
            visaProcessor.SetCallbackForVisaStatus(
            /* write a lambda expression to provide the callback function to VisaProcessor */
            () => Console.WriteLine("Visa Processed")
            ); ;
            foreach (var applicant in applicants)
                visaProcessor.ProcessVisa(applicant);
        }
    }
    /* Write code for class VisaProcessor */

    class Q3
    {
        //        Fill in the blanks with the line number(s) where boxing and unboxing is happening in the code
        //below.
        //1
        class TestBoxing
        //2 
        {
            //Converting a value type to a reference type is called called boxing in C#
            //and converting a reference type to a value type is called unboxing in C#. 
            //3 
            static void Main()

            //4 
            {
                //5 
                int i = 123;
                //6 
                object o = i;//Boxing
                //7 
                i = 456;
                //8
                int j = (int)o;//Unboxing
                //9 
                System.Console.WriteLine(i);
                //10 
                System.Console.WriteLine(j);
                Console.Read();
            }
        }
        // Boxing:……………………………6…………… Unboxing:………………7…………………………………
    }
}


namespace Q4
{

    //Consider the code below.The comment in the implementation function can be thought of as the
    //intended behavior of the object for that method. The comment /* no impl */ means that there is no
    //easy way for the object to implement the method.
    //Which of the SOLID principles the following code primarily violates? And, re-write the code to show how
    //will you fix it.
    interface IAnimal
    {
        virtual void Breathe();
    }

    /* your answer goes here */
    //it violates Interface Segregation Principle
    interface ISwimmable
    {
        void Swim();
    }
    interface IWalkable
    {
        void Walk();
    }
    class Fish : ISwimmable, IAnimal
    {
        public void Breathe() {/* breathe */}
        public void Swim() { /* swim */}
        //public void Walk() { /* no impl */}
    }
    class Bull : IWalkable, IAnimal
    {
        public void Breathe() { /* breathe */ }
        //public void Swim() { /* no impl */}
        public void Walk()
        { /* walk */}
    }
}