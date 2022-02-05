using System;

namespace PersonalityTestSwicth
{
    class Program
    {
        static void Main(string[] args)
        {
            //prorgamm küsib kasutajal sisestada tema lemmikvärv;
            //kui kasutaja sisetsab "punane", konsool kuvab "oled romantiline";
            //kui kasutaja sisetsab "sinine", konsool kuvab "oled töökas";
            //kui kasutaja sisetsab "roheline", konsool kuvab "oled looduse sõber";
            //kui kasutaja sisestab midagi muud, konsool kuvab "oled {userColor} ükssarvik" ;

            Console.WriteLine("Sisesta oma lemmikvärv:");
            string userColor = Console.ReadLine().ToLower();

            switch (userColor)
            {
                case "punane":
                    Console.WriteLine("Oled romantiline.");
                    break;
                case "roheline":
                    Console.WriteLine("Oled looduse sõber");
                    break;
                case "sinine":
                    Console.WriteLine("Oled töökas");
                    break;
                default:
                    Console.WriteLine($"Oled {userColor} ükssarvik");
                    break;

           
            }
            Console.WriteLine("Kena päeva!");
        }
    }
}
