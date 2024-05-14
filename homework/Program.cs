namespace homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Universe!");
            Console.WriteLine("Did you know that Jupiter has 95 moons?");
            int Jupiter_moons = 95;
            int Saturn_moons = 146;
            int Total_moons = Jupiter_moons + Saturn_moons;
            Console.WriteLine("The total number of moons in Jupiter and Saturn are" + Total_moons);
            string largest_saturn_moon = "Titan";
            string largest_jupiter_moon = "Ganymede";
            Console.WriteLine("The largest moon in Jupiter is" + largest_jupiter_moon);
            Console.WriteLine("The largest moon in Saturn is" + largest_saturn_moon);

            string galaxy1 = "Milky Way";
            decimal age_of_galaxy1 = 13.61M;
            Console.WriteLine("\n" + galaxy1 + "is the spiral galaxy we currently live in is approximately" + age_of_galaxy1 + "years old");

            string black_hole = "Sagittarius A*";
            int light_years_distance = 25000;
            Console.WriteLine("There is a " + black_hole + " in our solar system that is " + light_years_distance + " away from our planet, Earth.");

        }
    }
}
