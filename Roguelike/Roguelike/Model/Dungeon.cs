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

        public Dungeon(int tilesWidth, int tilesHeight)
        {
            map = new Tile[tilesWidth, tilesHeight];

            for (int i = 0; i < tilesWidth; i++)
            {
                for (int j = 0; j < tilesHeight; j++)
                {
                    map[i, j] = (i == 0 || j == 0 || i == tilesWidth - 1 || j == tilesHeight - 1) ? new Tile("tileWall") : new Tile("tileFloor");
                    map[i, j].setPosition(new Vector2(i * map[i, j].getSize().X, j * map[i, j].getSize().Y));
                    map[i, j].setRelativePosition(new Vector2(i, j));
                }
            }
        }

        public Tile[,] getMap()
        {
            return map;
        }

        internal void LoadContent(Microsoft.Xna.Framework.Content.ContentManager Content, Microsoft.Xna.Framework.Graphics.SpriteBatch sb)
        {
            foreach (Tile tile in map)
            {
                tile.LoadContent(Content, sb);
            }
        }

        internal void Update(GameTime gameTime)
        {
            //TODO
        }

        internal void Draw(GameTime gameTime, Microsoft.Xna.Framework.Graphics.SpriteBatch sb)
        {
            foreach (Tile tile in map)
            {
                tile.Draw(gameTime, sb);
            }
        }
    }
}
