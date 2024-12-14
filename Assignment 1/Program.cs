internal class Program
{
    private static void Main(string[] args)
    {
        #region Q1
        //Q1
        /*        Console.WriteLine("Enter a number");
                int Number = int.Parse(Console.ReadLine());
                Console.WriteLine("The user number = "+Number);*/
        #endregion

        #region Q2
        //Q2

        //Console.WriteLine("Enter a number");
        //int Number;
        //bool flag = int.TryParse(Console.ReadLine(), out Number);
        //Console.WriteLine(Number); //0
        //Console.WriteLine(flag);  //FALSE
        #endregion


        #region Q3
        /*        float X = 5.5f, Y = 2.3f;
        float Sum = X + Y;
        Console.WriteLine("Sum =" + Sum); //Sum =7.8*/
        #endregion


        #region Q4
        //string text = "Hello, World!";
        //string substring = text.Substring(7, 6);
        //Console.WriteLine("Substring: " + substring); 
        #endregion


        #region Q5
        //int X, Y;
        //X = 10;
        //Y = X;
        //X=5;
        //Console.WriteLine("X= "+X +","+ "Y= " +Y); //X= 5,Y= 10 
        #endregion

        #region Q6

        //Class1 object1 = new Class1();
        //object1.X = 12;
        //Console.WriteLine(object1.X); //12
        //object1.Y = object1.X;
        //Console.WriteLine(object1.Y); //12
        //object1.X = 5;
        //Console.WriteLine(object1.X);//5
        //Console.WriteLine(object1.Y);//12 
        #endregion

        #region Q7

        //string st1 = "Hello", st2 = "World";
        //string sum = st1 +" "+ st2;
        //Console.WriteLine(sum); 
        #endregion



        #region Q8
        //Console.WriteLine("Enter a principal");
        //double principal = double.Parse(Console.ReadLine());

        //Console.WriteLine("Enter a rate");
        //double rate = double.Parse(Console.ReadLine());

        //Console.WriteLine("Enter a time");
        //double time = double.Parse(Console.ReadLine());

        //double Interset = (principal * rate * time) / 100;
        //Console.WriteLine("The interset = "+Interset); 
        #endregion


        #region Q9
        //Console.Write("Enter weight (kg): ");
        //double weight = Convert.ToDouble(Console.ReadLine());
        //Console.Write("Enter height (m): ");
        //double height = Convert.ToDouble(Console.ReadLine());
        //double BMI = weight / (height * height);
        //Console.WriteLine("BMI: " + BMI); 
        #endregion


        #region Q10

        //Console.WriteLine("Enter the weather temperature ");
        //int Temperature = int.Parse(Console.ReadLine());
        //string flag = Temperature <10 ? "too cold" : Temperature > 30 ? "Just Hot" : "Just Good";
        //Console.WriteLine(flag);

        #endregion



        #region Q11
        //Console.Write("Enter day: ");
        //int day = Convert.ToInt32(Console.ReadLine());
        //Console.Write("Enter month: ");
        //int month = Convert.ToInt32(Console.ReadLine());
        //Console.Write("Enter year: ");
        //int year = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine($"Today’s date: {day}, {month}, {year}");
        //Console.WriteLine($"Today’s date: {day}/{month}/{year}");
        //Console.WriteLine($"Today’s date: {day}-{month}-{year}"); 
        #endregion


/*        Q12
         C) The event is on 06/14/2024
        //////////////////////////////////////////////////////////////////////
        
        Q13
         F)A value 1 will be assigned to d.
         Explanation: The condition !(30 < 20) EQUAL to true (1), so d = 1.

        //////////////////////////////////////////////////////////////////////
        Q14
        Console.WriteLine(13 / 2 + " " + 13 % 2);

        1)13%2 =1 
        2)13/2=6
        3)6+""+1=6 1
        D) 6 1

        ////////////////////////////////////////////////////////////////
        Q15
        int num = 1, z = 5;

        if (!(num <= 0))
            Console.WriteLine(++num + z++ + " " + ++z);
        else
            Console.WriteLine(--num + z-- + " " + --z);

        1)IF(TRUE)
        2)2+5 7 = 7 7
        D) 7 7*/
    }
}