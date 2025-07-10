using System;

namespace OlympicsProject
{
    public class Running100M : OlympicEvent
    {
        public Running100M() : base("Running 100M") { }

        public override void StartEvent()
        {
            Console.WriteLine("Running 100M is starting...");
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
            Console.WriteLine("Running 100M has ended.\n");
        }
    }
}
