using System.Collections.Generic;

namespace TopDownMovement
{
    public static class Input
    {
        public static Dictionary<Direction, bool> States { get; set; }

        public static bool GetState(Direction direction)
        {
            if (States.ContainsKey(direction))
            {
                return States[direction];
            }
            else
            {
                return false;
            }
        }

        public static void Clear()
        {
            States.Clear();
        }

        public static void AddState(Direction direction, bool isPressed)
        {
            if (!States.ContainsKey(direction))
            {
                States.Add(direction, isPressed);
            }
        }

        public static void Press(Direction direction)
        {
            AddState(direction, true);
        }

        public static void Release(Direction direction)
        {
            States[direction] = false;
        }
    }
}