﻿namespace Delegate
{
    internal class Program
    {
        public class Player
        {
            private Armor curArmor;

            public void Equip(Armor armor)
            {
                Console.WriteLine($"플레이어가 {armor.name} 을/를 착용합니다.");
                curArmor = armor;
                curArmor.OnBreaked += UnEquip;
                
            }

            public void UnEquip()
            {
                Console.WriteLine($"플레이어가 {curArmor.name} 을/를 헤제합니다.");
                //빈칸
                curArmor.OnBreaked -= UnEquip;
                curArmor = null;
            }

            public void Hit()
            {
                Console.WriteLine("플레이어가 피해를 받습니다.");
            }
        }

        public class Armor
        {
            public string name;
            private int durability;

            public event Action OnBreaked;

            public Armor(string name, int durability)
            {
                this.name = name;
                this.durability = durability;
            }
            public void DecreaseDurability()
            {
                durability--;
                if (durability <= 0) 
                {
                    Break();
                }
            }

            private void Break()
            {
                //과제 내용 입력
                Console.WriteLine("방어구가 부서졌습니다.");

                if(OnBreaked != null)
                {
                    OnBreaked();
                }
            }
        }

        static void Main(string[] args)
        {
           Player player = new Player();
            Armor amror = new Armor("갑옷", 3);

            player.Equip(amror);

            player.Hit();
            player.Hit();
            player.Hit();

        }
    }
}
