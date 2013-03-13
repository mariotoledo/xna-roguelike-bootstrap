using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Roguelike.Interfaces
{
    public interface Movable
    {
        void Move(Roguelike.Model.Tile toTile, MoveDirection direction);
    }

    public enum MoveDirection
    {
        Up,
        Down,
        Left,
        Right
    }
}
