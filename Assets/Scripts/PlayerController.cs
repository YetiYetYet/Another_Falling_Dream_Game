using System.Collections;
using System.Collections.Generic;
using MoreMountains.InfiniteRunnerEngine;
using Sirenix.OdinInspector;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public int speed;
    public float xAxis;
    public float zWordPointTarget;
    
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
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        /*_mousePosition = Input.mousePosition;
        _mousePosition.z = zWordPointTarget;
        _target = _camera.ScreenToWorldPoint(_mousePosition);
        _target.x = xAxis;*/

        _ray = _camera.ScreenPointToRay(Input.mousePosition);
        Debug.DrawRay(_ray.origin, _ray.direction * 10, Color.yellow);
        transform.position = Vector3.MoveTowards(transform.position, _target, speed * Time.deltaTime);
    }
}
