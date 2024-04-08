using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceAsignment.StateMachine
{
        public interface IState<Input, Output>
        {
            public IState<char, bool> NextStateFunction(char input);
            public bool OutputFunction(char input, StateMachine creature);
        }
    }
