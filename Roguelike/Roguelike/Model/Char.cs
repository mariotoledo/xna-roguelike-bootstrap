using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;

namespace Roguelike.Model
{
    public class Character : XNAObject
    {
        Texture2D Texture {get; set;}
        Vector2 Position {get; set;}
        Rectangle Rect {get; set;}

        private string _textureName;

        public Character() { }

        public Character(string textureName)
        {
            this._textureName = textureName;
        }

        public override void LoadContent(ContentManager Content, SpriteBatch sb)
        {
            if (_textureName == null)
                _textureName = "default";

            Texture = Content.Load<Texture2D>(@"Textures\" + _textureName);
            Position = new Vector2(100, 100);
            Rect = new Rectangle(0, 0, 64, 64);
        }

        public override void Update(GameTime gameTime)
        {
            
        }

        public override void Draw(GameTime gameTime, SpriteBatch sb)
        {
            sb.Draw(Texture, Position, Rect, Color.White);
        }
    }
}
