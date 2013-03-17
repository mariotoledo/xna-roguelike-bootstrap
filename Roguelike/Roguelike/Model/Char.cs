using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Roguelike.Interfaces;
using System.Diagnostics;

namespace Roguelike.Model
{
    public class Character : XNAObject, Movable
    {
        Texture2D Texture {get; set;}
        private Vector2 currentAbsolutePosition;
        private Tile currentRelativePosition; //related to tile position (matrix index)

        Rectangle Rect;
        Direction direction;
        State state;

        public enum State
        {
            None,
            isMoving
        }

        private string _textureName;

        public Character() { }

        public Character(string textureName, Tile initialPosition)
        {
            this._textureName = textureName;
            currentRelativePosition = initialPosition;
            this.currentAbsolutePosition = initialPosition.getPosition();
        }

        public Tile getRelativePosition()
        {
            return currentRelativePosition;
        }

        public void LoadContent(ContentManager Content, SpriteBatch sb)
        {
            if (_textureName == null)
                _textureName = "default";

            Texture = Content.Load<Texture2D>(@"Textures\" + _textureName);
            Rect = new Rectangle(15, 0, 32, 64);
        }

        public void Update(GameTime gameTime)
        {
            if (state == State.isMoving)
            {
                if (currentAbsolutePosition.X != currentRelativePosition.getPosition().X || currentAbsolutePosition.Y != currentRelativePosition.getPosition().Y)
                    UpdatePosition();
                else
                    state = State.None;
            }

            Debug.WriteLine("x: " + currentAbsolutePosition.X + " y: " + currentAbsolutePosition.Y);
        }

        public void Draw(GameTime gameTime, SpriteBatch sb)
        {
            sb.Draw(Texture, currentAbsolutePosition, Rect, Color.White);
        }

        public void Move(Tile toTile, Direction direction)
        {
            if (state == State.None)
            {
                currentRelativePosition = toTile;
                state = State.isMoving;
                setDirection(direction);
            }
        }

        private void setDirection(Direction direction){
            this.direction = direction;
            Rect.Y = this.Rect.Height * (int)direction;
        }

        private void UpdatePosition()
        {
            if (currentAbsolutePosition.X < currentRelativePosition.getPosition().X)
                currentAbsolutePosition.X += 1;
            else if (currentAbsolutePosition.X > currentRelativePosition.getPosition().X)
                currentAbsolutePosition.X = currentAbsolutePosition.X - 1;
            else if (currentAbsolutePosition.Y < currentRelativePosition.getPosition().Y)
                currentAbsolutePosition.Y = currentAbsolutePosition.Y + 1;
            else if (currentAbsolutePosition.Y > currentRelativePosition.getPosition().Y)
                currentAbsolutePosition.Y = currentAbsolutePosition.Y - 1;
        }
    }
}
