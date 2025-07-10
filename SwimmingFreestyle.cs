using System;

namespace OlympicsProject
{
    public class SwimmingFreestyle : OlympicEvent
    {
        public SwimmingFreestyle() : base("Freestyle Swimming") { }

        public override void StartEvent()
        {
            Console.WriteLine("Freestyle Swimming is starting...");
        }

        public override Athlete GetWinner()
        {
            Athlete best = null;
            int highest = -1;
            Random rnd = new Random();
            foreach (var a in Participants)
            {
                int result = a.Skill + rnd.Next(0, 5);
                if (result > highest)
                {
                    highest = result;
                    best = a;
                }
            }
            return best;
        }

        public override void EndEvent()
        {
            Console.WriteLine("Freestyle Swimming has ended.\n");
        }
    }
}
