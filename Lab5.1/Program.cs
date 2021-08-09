using System;
using System.Collections.Generic;

namespace Lab5._1
{
    public class GameCharacter
    {
        private string Name;
        private int Strength;
        private int Intelligence;

        public virtual void Play()
        {
            Console.WriteLine("");
        }

        public GameCharacter()
        {
            Name = Name;
            Strength = Strength;
            Intelligence = Intelligence;
        }
        public string GetName()
        {
            return Name;
        }
        public void SetName(string _Name)
        {
            Name = _Name;
        }
        public int GetStrength()
        {
            return Strength;
        }
        public void SetStrength(int _Strength)
        {
            Strength = _Strength;
        }
        public int GetIntelligence()
        {
            return Intelligence;
        }
        public void SetIntelligence(int _Intelligence)
        {
            Intelligence = _Intelligence;
        }
       
    }
    public class Warrior : GameCharacter
    {
        public string weaponType;
        public Warrior() 
        {

        }
        public override void Play()
        {
            Console.WriteLine($"{GetName()} (str {GetStrength()}, int {GetIntelligence()}) {weaponType}");
        }
    }
    class MagicUsingCharacter : GameCharacter
    {
        public MagicUsingCharacter() : base()
        {

        }
        public int MagicalEnergy;


    }
    class Wizard : MagicUsingCharacter
    {
        public Wizard()
        {

        }
        public int spellNumber;
        public override void Play()
        {
            Console.WriteLine($"{GetName()} (str {GetStrength()}, int {GetIntelligence()} magic {MagicalEnergy}) {spellNumber} spells");
        }
    }




    class Program
    {
        static void Main(string[] args)
        {
            Warrior w1 = new Warrior();
            w1.SetName("Conan");
            w1.SetStrength(4);
            w1.SetIntelligence(2);
            w1.weaponType = "Sword";

            Warrior w2 = new Warrior();
            w2.SetName("Bill");
            w2.SetStrength(6);
            w2.SetIntelligence(2);
            w2.weaponType = "Mace";

            Wizard wiz1 = new Wizard();
            wiz1.SetName("Timmy");
            wiz1.SetStrength(2);
            wiz1.SetIntelligence(9);
            wiz1.MagicalEnergy = 5;
            wiz1.spellNumber = 3;

            Wizard wiz2 = new Wizard();
            wiz2.SetName("Stubby");
            wiz2.SetStrength(4);
            wiz2.SetIntelligence(5);
            wiz2.MagicalEnergy = 7;
            wiz2.spellNumber = 3;


            Wizard wiz3 = new Wizard();
            wiz3.SetName("Wizboy");
            wiz3.SetStrength(3);
            wiz3.SetIntelligence(4);
            wiz3.MagicalEnergy = 3;
            wiz3.MagicalEnergy = 3;

            List<GameCharacter> characters = new List<GameCharacter>();
            characters.Add(w1);
            characters.Add(w2);
            characters.Add(wiz1);
            characters.Add(wiz2);
            characters.Add(wiz3);


            foreach (GameCharacter character in characters)
            {
                character.Play();
            }

        }
    }
}
