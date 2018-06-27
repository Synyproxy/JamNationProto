using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Managers
{
    public class InputManager : Singleton<InputManager>
    {

        public static bool Jump()
        {
            return Input.GetButton("Jump");
        }

        public static float Right()
        {
            if(Input.GetKey(KeyCode.D))
                return 1;
            return 0;
        }
        
        public static float Left()
        {
            if (Input.GetKey(KeyCode.A))
                return -1;
            return 0;
        }
    }
}