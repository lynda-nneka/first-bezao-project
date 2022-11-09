using System;


   public class breakcontinuefunction
    {
     public void runbreakcontinue()
      {
        int i = 0;
        while (i < 10)
        {
            Console.WriteLine(i);
            i++;
            if (i == 4)
            {
                continue;
            }
            if (i == 8)
            {
                break;
            }
        }
       }
     }
    


