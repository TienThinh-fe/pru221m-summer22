using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenBall : Ball
{
    // Start is called before the first frame update
    protected override void Start()
    {
        impulseVector.x = 0;
        impulseVector.y = 5;
        base.Start();
    }

    override protected void PrintMessage()
    {
        print("I'm a green  ball");
    }
}

