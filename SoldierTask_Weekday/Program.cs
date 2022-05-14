using System;

namespace SoldierTask_Weekday
{
    internal class Program
    {
        static void Main(string[] args)
        {
           

            do
            {
                int capaCapacity = Convert.ToInt32(Console.ReadLine());
                int Count = Convert.ToInt32(Console.ReadLine());
                bool IsAuto = Convert.ToBoolean(Console.ReadLine());

                Weapon weapon = new Weapon(capaCapacity, Count, IsAuto);


                Console.WriteLine("0   informasya almaq");
                Console.WriteLine("1   shoot method");
                Console.WriteLine("2   Fire method");
                Console.WriteLine("3   GetRaminBulletCount");
                Console.WriteLine("4   Relod method");
                Console.WriteLine("5   ChangeFireMode");
                Console.WriteLine("6   exit");
                int check = Convert.ToInt32(Console.ReadLine());

                switch (check)
                {
                    case 1:
                        weapon.Shoot();
                        break;
                    case 2:
                        weapon.Fire();
                        break;
                    case 3:
                        weapon.GetRemainBullentCount();
                        break;
                    case 4:
                        weapon.Reload();
                        break;
                    case 5:
                        weapon.ChangeFireMode();
                        break;
                    case 6:
                        
                        break;
                    default:
                        break;

                }

            } while (true);



        }
    }
}
