using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals
{
    internal class Program
    {
        static int health;
        static int score;
        static void Main(string[] args)
        {
            Console.WriteLine("Conditionals");
            Console.WriteLine("-------------");

            string gamertag;
            score = 0;
            
            gamertag = "MrJonesAndMe"; //pretend. would be read from the console (Xbox or other consoles)

            if (gamertag == "MrJonesAndMe") //= gets set to the value of
                //== is equal to
            {
                score = 1000000; //cheat
            }

            health = 100;

            TakeDamage(20);
            ShowHUD();
            TakeDamage(20);
            ShowHUD();
            TakeDamage(20);
            ShowHUD();
            TakeDamage(20);
            ShowHUD();
            TakeDamage(50);
            ShowHUD();

            Console.ReadKey(true);

        }

        static void ShowHUD()
        {
            string status;
            status = "Fine";
            if ((health > 49) && (health < 76))
            {
                status = "Just a Boo Boo";
            }

            if ((health >= 25) && (health <= 49))
            {
                status = "In a Pickle";
            }

            if ((health > 0) && (health < 25))
            {
                status = "Almost Dead";
            }

            if (health == 0)
            {
                status = "Worm Food";
            }

            Console.WriteLine(""+"");
            Console.WriteLine("Health: "+health);
            Console.WriteLine("Score: "+score);
            Console.WriteLine("Status: " + status);
        }

        static void TakeDamage(int damage)
        {
            health = health - damage;

            if (health < 0)
            {
                health = 0;
            }
        }

    }
}
