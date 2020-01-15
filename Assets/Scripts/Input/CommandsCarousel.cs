using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InputSystem
{
    public class CommandsCarousel
    {
        private Application _application;
        public CommandsCarousel()
        {
            _application = Application.Instance;
            _application.Initialized += InitializeCarousel;
        }

        public ICommands[] Commands
        {
        get{return _commands;}
        }    
        private static ICommands[] _commands = { new UnitChoiceCommands(), new BuildQueueCommands(),new GameArenaCommands()};
        private LinkedList<ICommands> _commandsCarousel = new LinkedList<ICommands>(_commands);

        void UpdateCurrentSelectedInCarousel()
        {
            _application.CurrentActivatedCommands = _commandsCarousel.First.Value;
        }

        void InitializeCarousel(object sender, EventArgs e)
        {
            UpdateCurrentSelectedInCarousel();
        }

        void SwapLeft()
        {
            LinkedListNode<ICommands> removedFirst = _commandsCarousel.First;
            _commandsCarousel.RemoveFirst();
            _commandsCarousel.AddLast(removedFirst);
            UpdateCurrentSelectedInCarousel();
        }
        void SwapRight()
        {
            LinkedListNode<ICommands> removedLast = _commandsCarousel.Last;
            _commandsCarousel.RemoveFirst();
            _commandsCarousel.AddFirst(removedLast);
            UpdateCurrentSelectedInCarousel();
        }
    }
}
