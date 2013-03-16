using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace Roguelike.Controller
{
    public class InputController
    {
        KeyboardState lastState;

        public delegate void KeyPressedHandler(object sender, KeyEventArgs key);
        // The event
        public event KeyPressedHandler KeyPressedEvent;

        #region Singleton
        private static InputController instance;

        public static InputController Instance
        {
            get 
              {
                 if (instance == null)
                 {
                    instance = new InputController();
                 }
                 return instance;
              }
        }
        #endregion

        public void Update()
        {
            Keys[] keyPressed = Keyboard.GetState().GetPressedKeys();
            foreach (Keys key in keyPressed)
            {
                if (lastState != null)
                {
                    if (lastState.IsKeyUp(key) && Keyboard.GetState().IsKeyDown(key))
                    {
                        OnKeyPressedEvent(this, new KeyEventArgs(key));
                    }
                }
            }

            lastState = Keyboard.GetState();
        }

        protected void OnKeyPressedEvent(object sender, KeyEventArgs e)
        {
            if (KeyPressedEvent != null)
            {
                KeyPressedEvent(this, e);
            }
        }
    }

    public class KeyEventArgs : EventArgs
    {
        public Keys key;
        public KeyEventArgs(Keys key)
        {
            this.key = key;
        }
    }
}
