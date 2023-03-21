using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PlayerBaseState : State
{
    //enter code here
    protected PlayerStateMachine StateMachine;

    public PlayerBaseState(PlayerStateMachine StateMachine)
    {
        this.StateMachine = StateMachine;
        
    }


}
