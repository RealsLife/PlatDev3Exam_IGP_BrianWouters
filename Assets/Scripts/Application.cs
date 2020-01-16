using InputSystem;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitChoiceSystem;
using UnityEngine;
using BuildQueueSystem;
using UnitSystem;

class Application : SingletonMonoBehaviour<Application>
    {
    public EventHandler Initialized;
    public event EventHandler ChangedCurrentCommands;
    public ICommands CurrentActivatedCommands
    {
        set
        {
            _currentActivatedCommands = value;
            ChangedCurrentCommands?.Invoke(this, EventArgs.Empty);
        }
    }
    public UnitChoice UnitChoice
    {
        get
        {
            return _unitChoice;  
        }
        set
        {
            _unitChoice = value;
        }
    }

    [SerializeField] private UnitChoiceView _prefabUnitChoiceView;
    [SerializeField] private BuildQueueView _prefabBuildQueueView;
    private InputHandler _inputHandler;
    private ICommands _currentActivatedCommands;
    private CommandsCarousel _commandCarousel;
    private UnitChoice _unitChoice;
    private BuildQueue<IUnit> _builQueue;
    public BuildQueue<IUnit> BuildQueue;
    public void Start()
    {
        BuildQueue = new BuildQueue<IUnit>(_prefabBuildQueueView);
        _inputHandler = new InputHandler();
        ChangedCurrentCommands += UpdateCurrentCommand;
        _commandCarousel = new CommandsCarousel();
        _unitChoice = new UnitChoice(_prefabUnitChoiceView);
        Initialized?.Invoke(this, EventArgs.Empty);
    }

    private void UpdateCurrentCommand(object sender, EventArgs e)
    {
        _currentActivatedCommands.Execute(_inputHandler);
    }

    private void Update()
    {
        _inputHandler.Update();
    }
}   