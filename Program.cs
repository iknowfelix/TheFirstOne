using System;
using System.Collections.Generic;
using System.Linq;


namespace Project4041
{


    class Character
    {
        //Stats for character.
        public string name;
        public int health;
        public int damage;
        public int critical;
        public int dodge;

        //Constructor
        public Character(string _name)
        {
            name = _name;
            int pointTotal = 100;
          
            {
                //Setting up random number generator.
                Random randNum = new Random();

                //Creating attribute values.
                //Portioning out 100 points between attributes. Each attributes has an initial random value
                //less than 25. After this each attribute will gain  asingle point until all 100 are allocated.
                //Stamina influences Health
                int randomNumber1 = randNum.Next(0, 25);
                int stamina = randomNumber1;
                pointTotal -= randomNumber1;
                Console.WriteLine("Stamina:" + stamina);

                //Strength influences Damage
                int randomNumber2 = randNum.Next(0, 25);
                int strength = randomNumber2;
                pointTotal -= randomNumber2;
                Console.WriteLine("Strength:" + strength);

                //Accuity influences Critical Hit
                int randomNumber3 = randNum.Next(0, 25);
                int accurity = randomNumber3;
                pointTotal -= randomNumber3;
                Console.WriteLine("Accurity:" + accurity);

                int randomNumber4 = randNum.Next(0, 25);
                int dexterity = randomNumber4;
                pointTotal -= randomNumber4;
                Console.WriteLine("Dexterity:" + dexterity);

                while (pointTotal >0)
                {
                    stamina++;
                    pointTotal--;

                    if (pointTotal >0)
                    {
                        strength++;
                        pointTotal--;

                    }
                    if (pointTotal > 0)
                    {
                        accurity++;
                        pointTotal--;
                    }
                    if (pointTotal > 0)
                    {
                        dexterity++;
                        pointTotal--;
                    }

                }
                //if pointTotal = 0
                //{
                //    break;
                //}
                //else
                //{
                //    
                //}
            }
           

            //stack creation in here.

            //create stats you want to use attributes
            // 
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            //Setting up random number generator.
            Random randNum = new Random();


            //Creating array of 15 names to be used in  creation of characters.
            string[] heroNameArray = { "Atlas", "Baal", "Cestis", "Daedalus", "Eve", "Fenrir", "Gretal", "Heimdalr", "Isis", "Juno", "Kali", "Loki", "Maat", "Neptune", "Ossia" };

            //Setting up character pool.
            List<Character> heroPool = new List<Character>();
          

            //Display names
            Console.WriteLine("Here are the fifteen heroes, ready to be chosen from.");
            foreach (string name in heroNameArray)
            {
                Console.WriteLine(name);
                heroPool.Add(new Character(name));
            }

            //Returns a random number less than the length of heroNameArray.
            int aRandomPos = randNum.Next(heroNameArray.Length);

//            //Creating characters.
//            Character char1 = new Character(string _name, int _health, int _damage, int _critical, int _dexterity);
//            {
//                //Uses random number to select a name from heroNameArray
//                string currName = heroNameArray[aRandomPos];
//                string _name = currName;


//                //creating a pool of points are attributed from for attributes.
//                List<int> pool = new List<int>();
//                {
//                    for 
//                }

//                int stamina = pool - //random number <= 25
//                int _health = stamina - //random number <= 25
//                int _acuity

//            }

//            Console.ReadKey();
        }
    }
}
