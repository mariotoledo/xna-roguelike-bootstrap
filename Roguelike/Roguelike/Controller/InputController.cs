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

        #region Singleton
        private static InputController instance;

        private InputController() { }

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

        public bool getKeyPressed(Keys key)
        {
            bool keyPressed = lastState.IsKeyDown(key) && Keyboard.GetState().IsKeyUp(key);
            lastState = Keyboard.GetState();
            return keyPressed;
        }
    }
}
