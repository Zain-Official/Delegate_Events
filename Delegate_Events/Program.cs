using System;

public delegate void onEventHandler(object sender, EventArgs e);
namespace Delegate_Events
{
    class Program
    {
        public static void Callback(object sender,EventArgs e)
        {
            Console.WriteLine("Got Five Numbers");
        }
        static void Main(string[] args)
        {
            fEvent fevt = new fEvent();
            fevt.FiveEvent += new onEventHandler(Callback);
            Random random = new Random();
            for(int i=0; i<5; i++)
            {
                int ro = random.Next(6);
                Console.WriteLine(ro);
                if(ro == 5)
                {
                    fevt.GotFive();
                }
            }

            Console.ReadKey();
        }
    }
}
