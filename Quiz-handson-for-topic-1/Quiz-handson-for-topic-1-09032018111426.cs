using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CricketAverage
{

 class WorldCup
    {
        public float target = 275;
        public int no_of_overs;
        public float runrate;
        public void RunRate()
        {
            try
            {
                var Input = Console.ReadLine();
                if (Input == "")
                {
                    Console.WriteLine("Overs should not be empty");
                }
                else
                {
                    no_of_overs = Convert.ToInt32(Input);
                    if (no_of_overs > 50)
                    {
                        Console.WriteLine("Over should be in the range 20 to 50");
                    }
                    else if (no_of_overs < 0)
                    {
                        Console.WriteLine("Over should be integer");
                    }
                    else if (no_of_overs < 20)
                    {
                        Console.WriteLine("Over should be in the range 20 to 50");
                    }
                    else
                    {
                        runrate = target / no_of_overs;
                        Console.WriteLine(runrate);
                    }
                }
            }
            catch (Exception e)
            {
                //Console.WriteLine(e.Message);
                Console.WriteLine("Overs Should be Integer");
            }
        }
    }
    class Finals
    {
        static void Main(string[] args)
        {

         WorldCup n = new WorldCup();
            n.RunRate();
            Console.ReadLine();
        }
    }
}