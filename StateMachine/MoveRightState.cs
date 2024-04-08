namespace AdvanceAsignment.StateMachine
{
    public class MoveRightState : IState<char, bool>
    {
        public IState<char, bool> NextStateFunction(char input)
        {
            switch (input)
            {
                case 'w': return new MoveUpState();
                case 's': return new MoveDownState();
                default: return new MoveRightState();


            }
        }

        public bool OutputFunction(char input, StateMachine snake)
        {
            snake.Move.X++;
            return true;
        }
    }
}