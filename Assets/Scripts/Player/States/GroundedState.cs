using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class GroundedState : BaseState
{
    protected override void OnEnter()
    {

    }

    protected override void OnUpdate()
    {
        if (sm.data.isGrounded && sm.rb.velocity.x < sm.data.moveSpeed)
        {
            float amount = Mathf.Min(Mathf.Abs(sm.rb.velocity.x), Mathf.Abs(sm.data.frictionAmount));
            amount *= Mathf.Sign(sm.rb.velocity.x);
            sm.rb.AddForce(Vector2.right * -amount, ForceMode2D.Impulse);
        }
    }

    protected override void OnExit()
    {

    } 
}