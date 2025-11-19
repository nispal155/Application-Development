using System;
namespace task4;

class Player
{
    public string PlayerName;
    public int Level;
    public int Health;

    public Player() // default constructor
    {
        Console.WriteLine("Default constructor has been called");
    }

    public Player(string playerName, int level, int health) // parameterized
    {
        PlayerName = playerName;
        Level = level;
        Health = health;
    }
}