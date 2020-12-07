using System;
using System.Collections;
using System.Collections.Generic;
using MoreMountains.InfiniteRunnerEngine;
using Sirenix.OdinInspector;
using UnityEditor;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public int speed;
    public LayerMask movableLayer;
    public Vector3 playerOffset;
    
    [SerializeField]
    private Vector3 _target;
    [SerializeField]
    private Vector3 _mousePosition;
    
    private Ray _ray;

    private Camera _camera;
    
    
    // Start is called before the first frame update
    void Start()
    {
        _camera = Camera.main;
        _target = transform.position;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (_target.y > transform.position.y)
        {
            Debug.Log("I go up");
        }
        else if (Math.Abs(_target.y - transform.position.y) < 0.1f)
        {
            Debug.Log("no y movement");
        }
        else
        {
            Debug.Log("move down");
        }

        _ray = _camera.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(_ray.origin, _ray.direction, out RaycastHit hit, Mathf.Infinity, movableLayer))
        {
            _target = hit.point;
            _target += playerOffset;
        }
        
        Debug.DrawRay(_ray.origin, _ray.direction * 10, Color.yellow);
        transform.position = Vector3.MoveTowards(transform.position, _target, speed * Time.deltaTime);
    }
}
