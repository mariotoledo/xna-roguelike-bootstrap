using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;

namespace Roguelike.Model
{
    public class Tile
    {
        private Vector2 position;
        private Vector2 size;

        public Tile(){
            size = new Vector2(32, 32);
        }

        public Vector2 getSize()
        {
            return size;
        }

        public Vector2 getPosition()
        {
            return position;
        }

        public void setPosition(Vector2 newPosition)
        {
            this.position = newPosition;
        }
    }
}
