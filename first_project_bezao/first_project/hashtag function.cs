using System;

   public class hashtagfunction
    {

        public void Runhashtagfunction()
        {

            Console.WriteLine("Enter your text");
            string text = Console.ReadLine();
            int words = text.Length - 4;
            int totalWords = text.Length;
            string hash = "#";
            string lastFourWords = text.Remove(0, words);

            for (int i = 0; i < words; i++)
            {
                Console.Write(hash);
            }
            Console.Write(lastFourWords);
            Console.Read();
        }
    }
    



