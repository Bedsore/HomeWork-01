using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Ball : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out BallCounter ballCounter))
        {
            ballCounter.ClapBall(this);
        }
    }
}
