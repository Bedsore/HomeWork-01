using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cursor : MonoBehaviour
{
    private Vector3 _mouseposition;
    // Start is called before the first frame update
    void Start()
    {
        UnityEngine.Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePos = Input.mousePosition;
        _mouseposition = Camera.main!.ScreenToWorldPoint(mousePos);
        transform.position = new Vector3(_mouseposition.x, 2, _mouseposition.z);
    }
}
