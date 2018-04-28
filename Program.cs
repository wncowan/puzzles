using System;

namespace puzzles
{
    class Program
    {
        public static int[] randomArray()
        {
            Random rand = new Random();
            int[] result = new int[10];
            int rando;
            for(int i = 0; i < 10; i++)
            {
                rando = rand.Next(5,25);
                result[i] = rando;
            }
            int max = result[0];
            int min = result[0];
            int sum = 0;
            for(int j = 0; j<result.Length; j++)
            {
                if(result[j] > max)
                {
                    max = result[j];
                }
                if(result[j] < min)
                {
                    min = result[j];
                }
                sum += result[j];
            }
            Console.WriteLine("max: " + max);
            Console.WriteLine("min: " + min);
            Console.WriteLine("sum: " + sum);

            foreach(int value in result)
            {
                Console.WriteLine(value);
            }

            return result;
        }

        public static string Toss_Coin()
        {
            Random rand = new Random();
            Console.WriteLine("Tossing a Coin!");
            int rando = rand.Next(0,2);
            Console.WriteLine(rando);
            if(rando == 0)
            {
                Console.WriteLine("Tails!");
                return "Tails";
            }
            else if(rando == 1)
            {
                Console.WriteLine("Heads!");
                return "Heads";
            }
            return "None";
        }
        public static double TossMultipleCoins(int num)
        {
            double heads_count = 0;
            double tails_count = 0;
            double ratio_heads_to_tails;
            Random rand = new Random();
            Console.WriteLine("Tossing a Coin!");
            int rando;

            for(int i = 0; i < num; i++)
            {
                rando = rand.Next(0,2);
                Console.WriteLine(rando);
                if(rando == 0)
                {
                    tails_count++;
                }
                else if(rando == 1)
                {
                    heads_count++;
                }
            }
            ratio_heads_to_tails = heads_count/tails_count;
            Console.WriteLine(heads_count);
            Console.WriteLine(tails_count);
            Console.WriteLine(ratio_heads_to_tails);
            return ratio_heads_to_tails;
        }

        public static string[] names()
        {
            Random rand = new Random();
            int rando;
            string temp;
            string[] my_names = {"Todd", "Tiffany", "Charlie", "Geneva", "Sydney"};
            for(int i = 0; i < my_names.Length; i++)
            {
                rando = rand.Next(0,my_names.Length);
                temp = my_names[rando];
                my_names[rando] = my_names[i];
                my_names[i] = temp; 
            }
            foreach(string name in my_names)
            {
                Console.WriteLine(name);
            }
            return my_names;
        }
        static void Main(string[] args)
        {
            names();
        }
    }
}
