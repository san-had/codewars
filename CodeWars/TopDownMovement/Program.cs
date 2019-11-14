namespace TopDownMovement
{
    internal class Program
    {
        private static PlayerMovement player;

        private static void Main(string[] args)
        {
            player = new PlayerMovement(0, 0);

            Input.Clear();

            Move();
        }

        private static void Move()
        {
            Press(Direction.Down);

            player.Update();
        }

        private static void Press(Direction direction)
        {
            Input.Press(direction);
        }

        private static void Release(Direction direction)
        {
            Input.Release(direction);
        }
    }
}