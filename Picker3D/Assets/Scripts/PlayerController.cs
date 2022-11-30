using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    private Rigidbody _rb;
    private float _objZPos;
    private float _movZ;

    private void Awake()
    {
        _rb = GetComponent<Rigidbody>();
    }
    private void OnMouseDown()
    {
        _objZPos = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;
    }
    private void OnMouseDrag()
    {
        var mousePoint = Input.mousePosition;
        mousePoint.z = _objZPos;
        _movZ = Camera.main.ScreenToWorldPoint(mousePoint).z;
    }

    void FixedUpdate()
    {
        var x = (speed * Time.deltaTime)*-1;
        var newPosition = transform.position + new Vector3(x, 0, 0);
        
        
        if(_movZ > 14.31f)

        {
            newPosition.z = 14.31f;
        }
        else if (_movZ < -14.91f)
        {
            newPosition.z = -14.91f;
        }
        else
        {
            newPosition.z = _movZ;
        }
        _rb.MovePosition(newPosition);
    }
}
