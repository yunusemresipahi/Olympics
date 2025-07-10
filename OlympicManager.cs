using System;
using System.Collections.Generic;

namespace OlympicsProject
{
    public class OlympicManager
    {
        private List<OlympicEvent> events = new List<OlympicEvent>();

        public void AddEvent(OlympicEvent ev)
        {
            events.Add(ev);
        }

        public void RunAll()
        {
            foreach (var ev in events)
            {
                ev.StartEvent();
                var winner = ev.GetWinner();
                winner.Award("gold");
                ev.EndEvent();
            }
        }
    }
}
