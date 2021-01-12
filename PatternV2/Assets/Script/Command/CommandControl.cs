using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using System.Linq;

public class CommandControl : MonoBehaviour
{
    private NavMeshAgent _agent;

    private Queue<Command> _commands = new Queue<Command>();
    private Command _curretCommand;

    private void Start() => _agent = GetComponent<NavMeshAgent>();

    private void Update()
    {
        ListerForCommands();
        ProcessCommands();
    }


    private void ListerForCommands()
    {
        if (Input.GetMouseButtonDown(0))
        {
            var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if(Physics.Raycast(ray, out var hitInfo))
            {
                MoveCommand moveCommand = new MoveCommand(hitInfo.point, _agent);
                _commands.Enqueue(moveCommand);
            }
        }
    }

    private void ProcessCommands()
    {
        if (_curretCommand != null && _curretCommand.IsFinished == false)
            return;
        if (_commands.Any() == false)
            return;

        _curretCommand = _commands.Dequeue();
        _curretCommand.Execute();
    }

    internal class MoveCommand : Command
    {
        private readonly Vector3 _Destination;
        private readonly NavMeshAgent _agent;

        public MoveCommand(Vector3 destination, NavMeshAgent _agent)
        {
            _Destination = destination;
            this._agent = _agent;
        }

        public override void Execute()
        {
            _agent.SetDestination(_Destination);
        }

        public override bool IsFinished => _agent.remainingDistance <= 0.1f;
    }
}
