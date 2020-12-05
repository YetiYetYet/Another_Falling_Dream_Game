using System;
using System.Collections;
using System.Collections.Generic;
using MoreMountains.InfiniteRunnerEngine;
using UnityEngine;

public class PlayerManager : PlayableCharacter
{
    protected override void OnTriggerEnter(Collider other)
    {
        Debug.Log("Player collide with + " + other.gameObject.name);
        if (other.tag.Equals("props"))
        {
            Debug.Log("I kill this player");
            LevelManager.Instance.KillCharacter(this);
        }
    }

    protected override void Update()
    {
        // we send our various states to the animator.      
        UpdateAnimator ();

        // if we're supposed to reset the player's position, we lerp its position to its initial position
        ResetPosition();
    }
}
