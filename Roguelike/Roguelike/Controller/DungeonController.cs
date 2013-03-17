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
                hero.Move(dungeon.getMap()[(int)hero.getRelativePosition().getRelativePosition().X, (int)hero.getRelativePosition().getRelativePosition().Y + 1], Interfaces.Direction.Down);
            if (e.key == Microsoft.Xna.Framework.Input.Keys.Up)
                hero.Move(dungeon.getMap()[(int)hero.getRelativePosition().getRelativePosition().X, (int)hero.getRelativePosition().getRelativePosition().Y - 1], Interfaces.Direction.Up);
            if (e.key == Microsoft.Xna.Framework.Input.Keys.Left)
                hero.Move(dungeon.getMap()[(int)hero.getRelativePosition().getRelativePosition().X - 1, (int)hero.getRelativePosition().getRelativePosition().Y], Interfaces.Direction.Left);
            if (e.key == Microsoft.Xna.Framework.Input.Keys.Right)
                hero.Move(dungeon.getMap()[(int)hero.getRelativePosition().getRelativePosition().X + 1, (int)hero.getRelativePosition().getRelativePosition().Y], Interfaces.Direction.Right);
        }
    }
}
