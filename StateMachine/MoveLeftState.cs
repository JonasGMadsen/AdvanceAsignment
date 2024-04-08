namespace AdvanceAsignment.StateMachine
{
    public class MoveLeftState : IState<char, bool>
    {
        public IState<char, bool> NextStateFunction(char input)
        {
            switch (input)
            {
                case 'w': return new MoveUpState();
                case 's': return new MoveDownState();
                default: return new MoveLeftState();


            }
        }

        public bool OutputFunction(char input, StateMachine snake)
        {
            snake.Move.X--;
            return true;
        }
    }
}