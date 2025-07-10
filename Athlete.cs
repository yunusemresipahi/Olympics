namespace OlympicsProject
{
    public class Athlete
    {
        public string Name { get; set; }
        public string Country { get; set; }
        public int Skill { get; set; }

        public Athlete(string name, string country, int skill)
        {
            Name = name;
            Country = country;
            Skill = skill;
        }

        public void Award(string medal)
        {
            Console.WriteLine($"{Name} from {Country} wins the {medal} medal.");
        }
    }
}
