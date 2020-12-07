using System;
using System.Collections;
using System.Collections.Generic;
using MoreMountains.InfiniteRunnerEngine;
using UnityEngine;

public class PlayerManager : PlayableCharacter
{
    private Vector3 _lastPosition;
    private Vector3 _position;
    public Vector3 direction;
    protected override void OnTriggerEnter(Collider other)
    {
        Debug.Log("Player collide with + " + other.gameObject.name);
        if (other.tag.Equals("Props"))
        {
            Debug.Log("I kill this player");
            LevelManager.Instance.KillCharacter(this);
        }
    }

    protected override void Start()
    {
        base.Start();
        _position = transform.position;
        _lastPosition = _position;
    }

    protected override void Update()
    {
        _position = transform.position;
        direction =  _position - _lastPosition ;
        if (direction.y > 0)
        {
            Debug.Log("i go up");
        }
        direction.Normalize();
        _lastPosition = _position;
    }
}
