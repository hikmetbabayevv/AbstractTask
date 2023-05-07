using System.Collections;
using System.Net.Security;
using System.Reflection.Emit;

namespace ConsoleApp11411
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string[] Menu = new string[] { "1. Yemekler", "2. Ickiler " , "3. Desertler "};
                User user1 = new Admin();
                Waiter user2 = new Waiter();
                user2.Menu = Menu;
                user2.TakeOrder(2);
                user2.OrderShow();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public abstract class User
        {
            public string Name { get; set; }
            public int Password { get; set; }

            public abstract void Introduce();
        }
        class Admin : User
        {
            public override void Introduce()
            {
                Console.WriteLine(Name);
            }
            public void GetReport()
            {

            }
        }
        class Waiter : User
        {
            public string[] Menu { get; set; }
            public ArrayList OrderList { get; set; }

            public Waiter()
            {
                OrderList = new ArrayList();
            }
            public void GiveMenu()
            {
                for (int i = 0; i < Menu.Length; i++)
                {
                    Console.WriteLine(Menu[i]);
                }
            }
            public void TakeOrder(int a)
            {
                if (a > Menu.Length)
                {
                    throw new Exception("Sifarisin nomresi siyahida yoxdur!!!!!");
                }
                OrderList.Add(Menu[a - 1]);
            }
            public void OrderShow()
            {
                for (int j = 0; j < OrderList.Count; j++)
                {
                    Console.WriteLine(OrderList[j]);
                }
            }
            public override void Introduce()
            {
                Console.WriteLine(Name);
            }
        }
    }
}