using System;
interface I1
{
    void ExplicitInterfaceMethod();
}
interface I2
{
    void ExplicitInterfaceMethod();
}
//for Default implementation
interface I3
{
    void ExplicitInterfaceMethod();
}
public class Program : I1, I2,I3
{
    //no access modifier
    public void ExplicitInterfaceMethod()
    {
        Console.WriteLine(this.GetType().ToString()+" default  implemented");
    }
    void I1.ExplicitInterfaceMethod()
    {
        Console.WriteLine(this.GetType().ToString()+" I1 implemented");
    }
    void I2.ExplicitInterfaceMethod()
    {
        Console.WriteLine(this.GetType().ToString()+" I2 implemented");
    }
    public static void Main(string[] args)
    {
        Program P = new Program();
        //P. No ExplicitInterface will be given in intellisense..you need to use typecast
        ((I1)P).ExplicitInterfaceMethod();
        ((I2)P).ExplicitInterfaceMethod();

        I1 i1 = new Program();
        I2 i2 = new Program();
        i1.ExplicitInterfaceMethod();
        i2.ExplicitInterfaceMethod();

        Program p = new Program();
        p.ExplicitInterfaceMethod();
        ((I1)p).ExplicitInterfaceMethod();
    }
}