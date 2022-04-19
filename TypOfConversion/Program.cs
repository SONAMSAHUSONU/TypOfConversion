//The process of converting one  type to another is called as type casting.
//when source type is not same as destination type then the source type has to convert in destination type.
//string =132;
//string is the variable and its value is the destination 
//type of conversion 
//1. implicity typ conversion: when type casting is happening automatically by CLR then it is called implicity type casting.
//2.widening is the process of converting lower data type to higher data type.This is safe conversion or upcasting or autoup casting or implicity type casting.
//byte b=100;
//int a=b;

/*
using System;
class Program
{
    static void Main(string[] args)
    {
        int i = 100;
        long l = i;
        Console.WriteLine(l);
        Console.ReadLine();
    }
}
*/
/*
using System;
class Program
{
    static void Main(string[] args)
    {
        byte b = 200;
        Console.WriteLine(b);
        int i = b;
        Console.WriteLine(i);
        long l = i;
        Console.WriteLine(l);
        float f = l;
        Console.WriteLine(f);
        double d = f;
        Console.WriteLine(d);
        char c = 'a';
        Console.WriteLine(c);
        int aa = c;
        Console.WriteLine(aa);
        long ll = c;
        Console.WriteLine(ll);
        float ff = c;
        Console.WriteLine(ff);
        //byte bb = c;
        //short ss = c;
        Console.ReadLine();

        }
    }*/
//explicit type casting : when type casting is done by programmer explicit then it is called as explicity type casting.
//1. norrowing : converting higher data type to lowe data type value is called the norrowing .it is called down casting also auto down casting expiicitly 

/*using System;
class Program
{
    static void Main(string[] args)
    {
        int i = 1000;
        byte bb = (byte)i;
        Console.WriteLine(bb);

        int j = 200;
        char ch = (char)j;
        Console.WriteLine(ch);

        float f  = 300.0f;
        byte bc = (byte)f;
        Console.WriteLine(bc);

        Console.ReadLine();

    }
}
*/


/*using System;
class Program
{
    static void Main(string[] args)
    {
        int i = 100;//implicity type casting 
        long l = i;
        Console.WriteLine(l);
        long ll = 66666;
        int i2 = (int)ll;//explicite typ casting 
        Console.WriteLine(ll);
        Console.ReadLine();
    }
}*/

/*using System;
class Program
{
    static void Main(string[] args)
    {
        char ch = 'A';   
        int i = ch;   //windening
        //Console.WriteLine(" ch ="+ ch );
        //Console.WriteLine( " i= "+ i);
        Console.WriteLine(ch + " =" + i);
        int i2 = 90;
        char ch2 = (char)i2; //norrowing
        //Console.WriteLine(" i2= "+ i2);
        // Console.WriteLine(" ch2="+ ch2);
        Console.WriteLine(ch2 +" =" + i2);
        Console.ReadLine();
    }
}*/