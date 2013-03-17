using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Roguelike.Model
{
    public class Tile : XNAObject
    {
        private Vector2 position;
        private Vector2 relativePosition;
        private Vector2 size;

        private string textureName;
        private Texture2D Texture;
        private Rectangle Rect;

        public Tile(){
            size = new Vector2(32, 32);
            textureName = "tileFloor";
        }

        public Tile(string textureName)
        {
            size = new Vector2(32, 32);
            this.textureName = textureName;
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

        public Vector2 getRelativePosition()
        {
            return relativePosition;
        }

        public void setRelativePosition(Vector2 newRelativePosition)
        {
            this.relativePosition = newRelativePosition;
        }

        public void LoadContent(Microsoft.Xna.Framework.Content.ContentManager Content, Microsoft.Xna.Framework.Graphics.SpriteBatch sb)
        {
            if (textureName == null)
                textureName = "default";

            Texture = Content.Load<Texture2D>(@"Textures\" + textureName);
            Rect = new Rectangle(0, 0, 32, 32);
        }

        public void Update(GameTime gameTime)
        {
            //TODO
        }

        public void Draw(GameTime gameTime, Microsoft.Xna.Framework.Graphics.SpriteBatch sb)
        {
            sb.Draw(Texture, getPosition(), Rect, Color.White);
        }
    }
}
