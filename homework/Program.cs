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
        }
    }
}
