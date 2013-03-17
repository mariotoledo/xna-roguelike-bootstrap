using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Roguelike.Interfaces
{
    public interface Movable
    {
        void Move(Roguelike.Model.Tile toTile, Direction direction);
    }

    public enum Direction
    {
        Down,
        Left,
        Right,
        Up
    }
}
