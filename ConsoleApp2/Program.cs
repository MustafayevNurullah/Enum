using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] workers = Enum.GetNames(typeof(Worker));

            Console.WriteLine("Enter Position");
            string position = Console.ReadLine();

            try
            {
                if (string.IsNullOrEmpty(position))
                {
                    throw new Exception("Enter empty Position");
                }
                if (string.IsNullOrWhiteSpace(position))
                {
                    throw new Exception("Enter null space");
                }
                bool workers_ = false;
                for (int i = 0; i < workers.Length; i++)
                {

                    if (workers[i] == position)
                    {
                        workers_ = true;
                    }
                    if (i == workers.Length - 1 && workers_ == false)
                    {
                        throw new Exception("Not found worker");
                    }


                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Environment.Exit(0);
            }
            Worker position_ = (Worker)System.Enum.Parse(typeof(Worker), position);
            Console.WriteLine("Enter day");
            int day = Convert.ToInt32(Console.ReadLine());




            if (true == Accauntant.AskForBonus((Worker)position_, day))
            {
                Console.WriteLine("Bonus qazandiniz");

            }
            else
            {
                Console.WriteLine("Bonus qazanmadiniz");
            }




        }
    }
    public enum Worker
    {
        Manager = 193,
        Developer = 200,
        Electric = 203,
        Supervisor = 198
    }
    struct Accauntant
    {

        public static bool AskForBonus(Worker position, int hours)
        {


            if (Worker.Developer == position && hours > (int)Worker.Developer)
            {



                return true;

            }
            if (Worker.Electric == position && hours > (int)Worker.Electric)
            {

                return true;

            }
            if (Worker.Supervisor == position && hours > (int)Worker.Supervisor)
            {

                return true;

            }
            if (Worker.Manager == position && hours > (int)Worker.Manager)
            {

                return true;

            }

            return false;

        }


    }
    class Myexception : Exception
    {
        public Myexception(string message) : base(message) { }
    }
}