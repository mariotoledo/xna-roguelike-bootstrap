using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Roguelike.Model;

namespace Roguelike.Controller
{
    public class DungeonController : XNAObject
    {
        Dungeon dungeon;
        Character hero;

        public DungeonController(Dungeon dungeon)
        {
            this.dungeon = dungeon;
            dungeon.InitialPosition = dungeon.getMap()[4, 4];

            hero = new Character("hero", dungeon.InitialPosition);
        }

        public override void LoadContent(Microsoft.Xna.Framework.Content.ContentManager Content, Microsoft.Xna.Framework.Graphics.SpriteBatch sb)
        {
            hero.LoadContent(Content, sb);
        }

        public override void Update(Microsoft.Xna.Framework.GameTime gameTime)
        {
            hero.Update(gameTime);
        }

        public override void Draw(Microsoft.Xna.Framework.GameTime gameTime, Microsoft.Xna.Framework.Graphics.SpriteBatch sb)
        {
            hero.Draw(gameTime, sb);
        }
    }
}
