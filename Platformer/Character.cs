using System;
namespace Character
{
    public abstract class Character
    {
        public uint Id { get; }
        public uint Hitpoints { get; set; }
        public bool Friendly { get; set; }
        public uint MoveSpeed { get; set; }
        public Position pos { get; set; }

        public Character(uint id)
        {
            Id = id;
        }
    }

    public struct Position
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Position(int x, int y)
        {
            X = x;
            Y = y;
        }
    }

    public class PlayerCharacter : Character
    {

    }

    public class NpcCharacter : Character
    {

    }
}

