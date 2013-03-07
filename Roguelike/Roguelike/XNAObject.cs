using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;

namespace Roguelike
{
    public abstract class XNAObject
    {
        public abstract void LoadContent(ContentManager Content, SpriteBatch sb);
        public abstract void Update(GameTime gameTime);
        public abstract void Draw(GameTime gameTime, SpriteBatch sb);
    }
}
