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

            InputController.Instance.KeyPressedEvent += new InputController.KeyPressedHandler(KeyPressed);
        }

        public void LoadContent(Microsoft.Xna.Framework.Content.ContentManager Content, Microsoft.Xna.Framework.Graphics.SpriteBatch sb)
        {
            hero.LoadContent(Content, sb);
        }

        public void Update(Microsoft.Xna.Framework.GameTime gameTime)
        {
            hero.Update(gameTime);
        }

        public void Draw(Microsoft.Xna.Framework.GameTime gameTime, Microsoft.Xna.Framework.Graphics.SpriteBatch sb)
        {
            hero.Draw(gameTime, sb);
        }

        public void KeyPressed(object a, KeyEventArgs e)
        {
            if(e.key == Microsoft.Xna.Framework.Input.Keys.Down)
                hero.Move(dungeon.getMap()[(int)hero.getTile().getRelativePosition().X, (int)hero.getTile().getRelativePosition().Y + 1], Interfaces.MoveDirection.Down);
        }
    }
}
