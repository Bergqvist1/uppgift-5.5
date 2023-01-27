using System;
namespace Uppgift_5_5
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] svar = new string[10];

            svar[0] = "Absolut kompis";
            svar[1] = "Jag tycka det är bra";
            svar[2] = "Mycket gott";
            svar[3] = "Lägg av nu";
            svar[4] = "Ta det lite keno grabben";
            svar[5] = "Du behöver Jesus";
            svar[6] = "Inte bra kombis";
            svar[7] = "Det här är semantiskt fantastiskt";
            svar[8] = "Det la veckan de va";
            svar[9] = "SUUUUUI";

            Random slump = new Random();

            Console.WriteLine("Hur många frågor vill du ställa?");
            int antal = int.Parse(Console.ReadLine());
            string[] frågor = new string[antal];

            for(int i = 0; i < antal; i++)
            {
                int val = slump.Next(svar.Length);
                Console.WriteLine("Skriv din" + " " + (i+1) + " fråga ");
                string fråga = Console.ReadLine();
                Console.WriteLine("\n" + svar[val]);


            }




        }
    }
}
