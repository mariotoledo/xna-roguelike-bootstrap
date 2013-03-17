using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Roguelike.Interfaces;

namespace Roguelike.Model
{
    public class Character : XNAObject, Movable
    {
        Texture2D Texture {get; set;}
        Tile tilePosition; //related to tile position (matrix index)
        Rectangle Rect;
        State state;
        Direction direction;

        public enum State
        {
            None,
            isMoving
        }

        private string _textureName;

        public Character() { }

        public Character(string textureName, Tile tilePosition)
        {
            this._textureName = textureName;
            this.tilePosition = tilePosition;
        }

        public void setTile(Tile tile)
        {
            this.tilePosition = tile;
        }

        public Tile getTile()
        {
            return tilePosition;
        }

        public void LoadContent(ContentManager Content, SpriteBatch sb)
        {
            if (_textureName == null)
                _textureName = "default";

            Texture = Content.Load<Texture2D>(@"Textures\" + _textureName);
            Rect = new Rectangle(0, 0, 64, 64);
        }

        public void Update(GameTime gameTime)
        {
            
        }

        public void Draw(GameTime gameTime, SpriteBatch sb)
        {
            sb.Draw(Texture, tilePosition.getPosition(), Rect, Color.White);
        }

        public void Move(Tile toTile, Direction direction)
        {
            tilePosition = toTile;
            setDirection(direction);
        }

        private void setDirection(Direction direction){
            this.direction = direction;
            Rect.Y = this.Rect.Height * (int)direction;
        }
    }
}
