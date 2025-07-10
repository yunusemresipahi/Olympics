using System;
using NUnit.Framework;
using System.Collections.Generic;

[TestFixture]
public class OlympicsTests
{
    [Test]
    public void Athlete_Creation_ShouldStoreCorrectValues()
    {
        var athlete = new Athlete("Mark", "USA", 9);

        Assert.AreEqual("Mark", athlete.Name);
        Assert.AreEqual("USA", athlete.Country);
        Assert.AreEqual(9, athlete.Skill);
    }

    [Test]
    public void Running100M_ShouldReturnWinnerFromParticipants()
    {
        var event100m = new Running100M();
        var a1 = new Athlete("Ali", "Turkey", 8);
        var a2 = new Athlete("John", "USA", 9);

        event100m.AddParticipant(a1);
        event100m.AddParticipant(a2);

        var winner = event100m.GetWinner();

        Assert.Contains(winner, new List<Athlete> { a1, a2 });
    }

    [Test]
    public void Events_ShouldBePolymorphic()
    {
        List<OlympicEvent> events = new List<OlympicEvent>();
        events.Add(new Running100M());
        events.Add(new SwimmingFreestyle());
        events.Add(new HighJump());

        foreach (var ev in events)
        {
            Assert.DoesNotThrow(() =>
            {
                ev.StartEvent();
                var winner = ev.GetWinner();
                ev.EndEvent();
            });
        }
    }
}
