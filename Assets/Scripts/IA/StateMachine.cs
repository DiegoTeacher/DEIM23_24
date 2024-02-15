using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
[RequireComponent(typeof(NavMeshAgent))]

public class StateMachine : MonoBehaviour
{
    public State initialState;
    public State _currentState;

    // Start is called before the first frame update
    void Start()
    {
        ChangeState(initialState);
    }

    // Update is called once per frame
    void Update()
    {
        State nextState = _currentState.Run(gameObject);

        if(nextState)
        {
            ChangeState(nextState);
        }
    }

    void ChangeState(State newState)
    {
        _currentState = newState;
        _currentState.Init(gameObject);
    }

    private void OnDrawGizmos()
    {
        if(_currentState != null)
            _currentState.DrawAllGizmos(gameObject);
    }
}
