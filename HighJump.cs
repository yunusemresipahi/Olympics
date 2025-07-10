using System;

namespace OlympicsProject
{
    public class HighJump : OlympicEvent
    {
        public HighJump() : base("High Jump") { }

        public override void StartEvent()
        {
            Console.WriteLine("High Jump is starting...");
        }

        public override Athlete GetWinner()
        {
            Athlete best = null;
            int highest = -1;
            Random rnd = new Random();
            foreach (var a in Participants)
            {
                int result = a.Skill + rnd.Next(1, 4);
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
            Console.WriteLine("High Jump has ended.\n");
        }
    }
}
