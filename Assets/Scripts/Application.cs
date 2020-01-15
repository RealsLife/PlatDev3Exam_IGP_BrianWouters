using InputSystem;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

class Application : SingletonMonoBehaviour<Application>
    {
    private InputHandler _inputHandler;
    public EventHandler Initialized;
    event EventHandler ChangedCurrentCommands;
    ICommands _currentActivatedCommands;
    CommandsCarousel _commandCarousel;
    public ICommands CurrentActivatedCommands
    {
        set
        {           
            _currentActivatedCommands = value;
            ChangedCurrentCommands?.Invoke(this, EventArgs.Empty);
        }
    }
    public void Start()
    {
        _inputHandler = new InputHandler();
        _commandCarousel = new CommandsCarousel();
        Initialized?.Invoke(this, EventArgs.Empty);
        ChangedCurrentCommands += UpdateCurrentCommand;
        StartCoroutine(LateInitialize());
    }

    private void UpdateCurrentCommand(object sender, EventArgs e)
    {
        _currentActivatedCommands.Execute(_inputHandler);
    }

    private void Update()
    {
        _inputHandler.Update();
    }

    IEnumerator LateInitialize()
    {
        yield return new WaitForEndOfFrame();
        Initialized?.Invoke(this, EventArgs.Empty);
    } 
}   