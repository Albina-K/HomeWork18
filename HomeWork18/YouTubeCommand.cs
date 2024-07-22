using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork18
{
    class YouTubeCommand
    {
        ICommand _command;

        public void SetCommand(ICommand command)
        {
            _command = command;
        }
        public void Run()
        {
            _command.Run();
        }
    }
}
