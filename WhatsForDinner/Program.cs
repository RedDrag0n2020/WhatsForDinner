using Microsoft.Win32.SafeHandles;
using System.Runtime.InteropServices;

namespace WhatsForDinner
{
    internal class Program
    {
        static string[] mainCourse = { "hamburgers", 
            "tacos", "meatloaf", "BBQ pulled pork", 
            "BBQ chicken", "fish patties", "pizza", 
            "lasagna", "spaghetti", "ham steak", 
            "ham, potatoes, and onions", "chicken & yellow rice",
            "fried chicken", "chinese food", "Philly cheese steaks", 
            "hot dogs", "ham & beans","pork loin","pot roast", "ribs","coneys",
            "chicken nuggets", "grilled ham & cheese sandwiches", "chicken sandwiches",
            "sloppy joes", "shrimp alfredo", "swedish meatballs"
            };

        static string[] sides = {"mashed potatoes", "brown rice", "mashed cheese potatos",
        "quarted cheese potatos", "dinner roll", "french fries", "baked potato",
        "baked beans",      
        };

        static string[] vegetables = {"corn", "lima beans", "peas",
        "broccoli with cheese", "cauliflower with cheese", "green beans", "salad", "corn on the cob",
        "corn", "mexican corn", 
        };
        
        static void Main(string[] args)
        {
            SayHello();
            AskWhatsForDinner();
            SelectRandomMainCourse();
            SelectRandomSide();
            SelectRandomVegetable();

            
        }

        static void SayHello()
        {
            Console.WriteLine("Hello Ken!");

        }

        static void AskWhatsForDinner()
        { Console.WriteLine("What's for dinner?");  
            
        }

        static void SelectRandomMainCourse()
        {
            Random random = new Random();
            int index = random.Next(mainCourse.Length);
            string randomMainCourse = mainCourse[index];
            Console.WriteLine(randomMainCourse);

        }

        static void SelectRandomSide()
        {
            Random random = new Random();
            int index = random.Next(sides.Length);
            string randomSide = sides[index];
            Console.WriteLine(randomSide);
        }

        static void SelectRandomVegetable()
        {
            Random random = new Random();
            int index = random.Next(vegetables.Length);
            string randomVegetable = vegetables[index];
            Console.WriteLine(randomVegetable);
        }

    }
}
