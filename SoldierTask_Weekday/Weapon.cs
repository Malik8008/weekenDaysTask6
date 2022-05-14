using System;
using System.Collections.Generic;
using System.Text;

namespace SoldierTask_Weekday
{
    internal class Weapon
    {
        public static int Capacity { get; set; }
        public static int Count { get; set; }
        public static bool IsAuto { get; set; }


        public Weapon(int capacity, int count, bool isauto)
        {
            Capacity = capacity;
            Count = count;
            IsAuto = isauto;
        }



        public void Shoot()
        {
            if (IsAuto == false)
            {
                Count = Count - 1;
            }
            Console.WriteLine(Count);

        }

        public void Fire()
        {
            if (IsAuto == true)
            {
                for (int i = 0; i < Count; i--)
                {
                    if (Count > 0)
                    {
                        Count--;
                        Console.WriteLine(Count);
                    }
                }
            }
        }


        public int GetRemainBullentCount()
        {
            return Capacity - Count;
        }


        public void Reload()
        {
            Console.WriteLine(Capacity = Count + GetRemainBullentCount());
        }


        public void ChangeFireMode()
        {
            if (IsAuto == false)
            {
                IsAuto = true;
            }
            else if (IsAuto == true)
            {
                IsAuto = false;
            }
        }

       


    }
}
