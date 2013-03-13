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

        public void LoadContent(Microsoft.Xna.Framework.Content.ContentManager Content, Microsoft.Xna.Framework.Graphics.SpriteBatch sb)
        {
            hero.LoadContent(Content, sb);
        }

        public void Update(Microsoft.Xna.Framework.GameTime gameTime)
        {
            if (InputController.Instance.getKeyPressed(Microsoft.Xna.Framework.Input.Keys.Down))
                hero.Move(dungeon.getMap()[(int)hero.getTile().getRelativePosition().X, (int)hero.getTile().getRelativePosition().Y + 1], Interfaces.MoveDirection.Down);

            if (InputController.Instance.getKeyPressed(Microsoft.Xna.Framework.Input.Keys.Up))
                hero.Move(dungeon.getMap()[(int)hero.getTile().getRelativePosition().X, (int)hero.getTile().getRelativePosition().Y - 1], Interfaces.MoveDirection.Up);

            if (InputController.Instance.getKeyPressed(Microsoft.Xna.Framework.Input.Keys.Left))
                hero.Move(dungeon.getMap()[(int)hero.getTile().getRelativePosition().X + 1 , (int)hero.getTile().getRelativePosition().Y], Interfaces.MoveDirection.Left);

            if (InputController.Instance.getKeyPressed(Microsoft.Xna.Framework.Input.Keys.Right))
                hero.Move(dungeon.getMap()[(int)hero.getTile().getRelativePosition().X - 1, (int)hero.getTile().getRelativePosition().Y], Interfaces.MoveDirection.Right);

            hero.Update(gameTime);
        }

        public void Draw(Microsoft.Xna.Framework.GameTime gameTime, Microsoft.Xna.Framework.Graphics.SpriteBatch sb)
        {
            hero.Draw(gameTime, sb);
        }
    }
}
