namespace AdvanceAsignment.StateMachine
{
    public class MoveDownState : IState<char, bool>
    {
        public IState<char, bool> NextStateFunction(char input)
        {
            switch (input)
            {
                case 'a': return new MoveLeftState();
                case 'd': return new MoveRightState();
                default: return new MoveDownState();
            }
        }

        public bool OutputFunction(char input, StateMachine snake)
        {
            snake.Move.Y++;
            return true;
        }
    }
}