using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;

namespace Roguelike
{
    public interface XNAObject
    {
        void LoadContent(ContentManager Content, SpriteBatch sb);
        void Update(GameTime gameTime);
        void Draw(GameTime gameTime, SpriteBatch sb);
    }
}
