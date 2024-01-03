using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Example : MonoBehaviour
{
    [SerializeField] private Sherif _sherif;
    [SerializeField] private Transform _target;
    [SerializeField] private List<Transform> _patrolPoints;

    private void Awake()
    {
        _sherif.SetMover(new NoMovePattern());
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            Debug.Log("I'm stop");
            _sherif.SetMover(new NoMovePattern());
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            Debug.Log("Going to targets");
            _sherif.SetMover(new PointByPointMover(_sherif, _patrolPoints.Select(point => point.position)));
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            Debug.Log("I will founf you beatch");
            _sherif.SetMover(new MoveToTargetPattern(_sherif, _target));
        }
    }
}
