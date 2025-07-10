namespace OlympicsProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Athlete a1 = new Athlete("Ali", "Turkey", 8);
            Athlete a2 = new Athlete("John", "USA", 9);
            Athlete a3 = new Athlete("Yuki", "Japan", 7);

            var running = new Running100M();
            running.AddParticipant(a1);
            running.AddParticipant(a2);

            var swimming = new SwimmingFreestyle();
            swimming.AddParticipant(a2);
            swimming.AddParticipant(a3);

            var highJump = new HighJump();
            highJump.AddParticipant(a1);
            highJump.AddParticipant(a3);

            var manager = new OlympicManager();
            manager.AddEvent(running);
            manager.AddEvent(swimming);
            manager.AddEvent(highJump);

            manager.RunAll();
        }
    }
}
