using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieProjectile : Projectile
{
    override protected void Start()
    {
        impulseForce.x = 3f;
        base.Start();
    }
}
