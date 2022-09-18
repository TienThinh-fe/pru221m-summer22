using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedBall : Ball
{
    protected override void Start()
    {
        impulseVector.x = 5;
        impulseVector.y = 5;
        base.Start();
    }

    protected override void PrintMessage()
    {
        print("I'm a red ball");
    }
}
