using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//this is my basic state class

public abstract class State
{
    public abstract void Enter();
    public abstract void Tick(float delatTime);
    public abstract void Exit();
}
