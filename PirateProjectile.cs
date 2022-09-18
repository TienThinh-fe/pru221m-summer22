using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PirateProjectile : Projectile
{
    override protected void Start()
    {
        impulseForce.x = 2f;
        base.Start();
    }
}
