using System;


   public class GetDateFunction
   {
     public void RunDateFunction()
        {
            Console.WriteLine("Enter the date MM/dd/yyyy");
            string todayDate = Console.ReadLine();
            DateTime stringtoDate = DateTime.Parse(todayDate);
            DateTime afterWeek = stringtoDate.AddDays(7);

            Console.WriteLine(afterWeek);
        Console.ReadKey();
        }
        
    }


