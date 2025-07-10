This project is made to model some Olympic sports events on the computer. The goal is to use object-oriented programming concepts to represent different sports and athletes.

There is an abstract class called OlympicEvent which acts as the base for all sports. From this, classes like Running, Swimming, and High Jump are created. Each sport has its own methods to start the event, choose a winner, and end the event.

Athletes are represented by the Athlete class, which stores their name, country, and skill level. The winner is chosen based on the athlete’s skill and some randomness.

There is also an OlympicManager class that manages and runs all the events in order.