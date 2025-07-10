using System;
using System.Collections.Generic;

namespace OlympicsProject
{
    public abstract class OlympicEvent
    {
        public string Name { get; set; }
        public List<Athlete> Participants { get; set; }

        public OlympicEvent(string name)
        {
            Name = name;
            Participants = new List<Athlete>();
        }

        public void AddParticipant(Athlete athlete)
        {
            Participants.Add(athlete);
        }

        public abstract void StartEvent();
        public abstract Athlete GetWinner();
        public abstract void EndEvent();
    }
}
