using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseState
{
    protected StateMachine sm;
    protected Vector3 horizontalMovement;

    public void OnStateEnter(StateMachine stateMachine)
    {
        // this code will always be called
        sm = stateMachine;
        OnEnter();
    }

    protected virtual void OnEnter()
    {
        // this code can be overwritten in the derived classes
    }

    public void OnStateUpdate()
    {
        OnUpdate();
    }

    protected virtual void OnUpdate()
    {

    }

    public void OnStateMove(float _horizontalMovement)
    {
        horizontalMovement = Vector3.right * _horizontalMovement;
        OnMove();
    }

    protected virtual void OnMove()
    {

    }

    public void OnStateExit()
    {
        OnExit();
    }

    protected virtual void OnExit() 
    {
    
    }
}
