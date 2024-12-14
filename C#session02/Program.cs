using System;
using System.Drawing;
using System.Security.Cryptography;
using C_session02;

internal class Program
{
    private static void Main(string[] args)
    {
        #region variable declaration
        /*variable
         * 
         1.name :number
        2.datatype:int
        3.size:4 bytes
        4.values:5
        5.address:0xf2a


        Variable declaratiom
        datatype variablename
        int number; //alocate uninitialized 4 bytes at memory
        int number = 5;
        int number =1,num2=4,number3=3;
        Console.WriteLine(number3);
        */

        #endregion

        #region DATATYPE VALUE TYPE
        ////datatype(value type):stack
        ////declare variable
        //int number; //value type
        ////allocate uninitilized 4 bytes at stack
        ////int :c# keyword

        ////BCL: int32

        //Int32 number02;
        //number = 12;
        //Console.WriteLine(number); 
        #endregion

        #region Datetype(reference type): Heap)
        /*
        POINT po1; //reference
        //declare refernce from type 'point'
        //po1 : can refer to object from type 'point'
        //8 bytes will be allocated at stack for the 'po1'
        //8 bytes will be allocates at heap

        //console.writeline(po1); //invalied before new

        po1 = new POINT();

        //new 
        //1.allocate for the number of required bytes for the object at heap
        //2.initialized the allocated bytes with the default value of the datatype
        //3.call user-defined constructor if exist
        //4.assign the object address to the reference 'po1'

        Console.WriteLine(po1.x); //0
        Console.WriteLine(po1.y); //0
        Console.WriteLine(po1);  //C_session02.POINT
        
        POINT Po2 = new POINT();
        Po2.x = 12;
        Console.WriteLine(po1.x);
        Console.WriteLine(Po2.x);

        po1 = Po2;
        Console.WriteLine(po1.x);
        Console.WriteLine(Po2.x);
*/
        #endregion

        #region object
        /*        object o01;
        //declare for reference from type 'object'
        //001: can refer to instance from type 'object' or any type inherited from object

        o01 = new object();
        o01 = 1;
        o01 = 'A';
        o01 = 1.2;
        o01 = true;
        o01 = new POINT();

        Console.WriteLine(o01);

        POINT po1 = new POINT();
        Console.WriteLine(po1.ToString());*/
        #endregion

        #region casting

        /*        //cassting: convert from any datatype to any datatype
                //1.implicit casting : by7sl lwahdo mn clr
                int x = 5;
                double y = *//*(double)*//* x;
                //2.explicit casting

                double w = 2.5;
                int z = (int)w;
        
        //explicit                                   

        long x = 111111111111;
        int y = (int )x; 

        */

        #endregion


        #region convert,parse,tryparse
        //parse : function
        /*
                Console.WriteLine('enter your age');
                Console.ReadLine();//save as string
                //int age = Console.ReadLine(); //invalid
                int age = int.Parse(Console.ReadLine()); //convert to int
                double gpa = double.Parse(Console.ReadLine());
                Console.WriteLine(age);

                // convert
                int age = Convert.ToInt32(Console.ReadLine());

                //tryparse :to avoid errors

                Console.WriteLine("enter your age");
                int age;
                   bool flag = int.TryParse(Console.ReadLine(),out age);
                Console.WriteLine(age);
                Console.WriteLine(flag);
        */
        #endregion



        #region fration and discard
        //fraction
        /*        double x = 1.5;
                float y = 1.5f;
                decimal z = 1.5m;
      


        int x = 1_000_000_000; //discard_ for readability only

          */

        #endregion


        #region operators

        //operators
        /*
                //1.unary operators:work on one operand (variable)  ++ --
                int x = 10;
                x++;
                ++x;
                //prefix[increment then print]
                Console.WriteLine(++x); //11
                //postfix [print then increment]
                Console.WriteLine(x++);//10 then //11
       



        //binary operation : works on two operands (variables)

        //+ =/*
        int sum, mul, sub, mod;
        int number101 = 2, number02 = 5;
        sum = number101 + number02;
        mul = number101 * number02;
        sub = number101 - number02;
        mod = number101 % number02;


        //20%3=2

        

        //assignment operators = ,+= -= %= /=

        int x = 4;
        x += 2;
        x -= 2;
        x /= 2;
        x *= 2;
        x %= 2;
       

        //relational operatore != > < >= <= ==

        int x = 5, y = 6;
        Console.WriteLine(x == y);
        Console.WriteLine(x != y);
        Console.WriteLine(x <= y);
        Console.WriteLine(x >= y);
        Console.WriteLine(x > y);
         

        //logical operzation and && or || not !

        Console.WriteLine(!false);

        Console.WriteLine(false && true); ///short circuit lw awel wahda 5alas false msh hashof el tania

        Console.WriteLine(false || true);
       

        //6. bitwise operators

        Console.WriteLine(!false);

        Console.WriteLine(false & true); ///long  circuit lazm ashof el etnen hata lw awel wahda false

        Console.WriteLine(false | true);

         
        //ternary operatoe[conditional operator]
        bool flag = 4 > 2;
        Console.WriteLine(flag);
         

        string flag = 4 > 2 ? "true" : "false"; // lw false hybos 3ala condition el ba3d : w el 3aks
        Console.WriteLine(flag);
        */ 
        #endregion




    }
}