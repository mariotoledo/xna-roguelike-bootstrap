using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;

namespace Roguelike.Model
{
    public class Dungeon
    {
        private Tile[,] map;
        public Tile InitialPosition {get; set;}

        public Dungeon() { }

        public Dungeon(int numberTiles)
        {
            map = new Tile[numberTiles, numberTiles];
            for (int i = 0; i < numberTiles; i++)
            {
                for (int j = 0; j < numberTiles; j++)
                {
                    map[i, j] = new Tile();
                    map[i, j].setPosition(new Vector2(i * map[i, j].getSize().X, j * map[i, j].getSize().Y));
                    map[i, j].setRelativePosition(new Vector2(i, j));
                }
            }
        }

        public Tile[,] getMap()
        {
            return map;
        }
    }
}
