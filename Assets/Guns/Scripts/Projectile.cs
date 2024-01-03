using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    void Update()
    {
        transform.Translate(transform.forward * 0.2f);
    }
}
