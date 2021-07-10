﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    private Animator anim = null;
    private Player player = null;

    private void Awake()
    {
        anim = GetComponent<Animator>();
        player = GetComponent<Player>();
    }

    private void Update()
    {
        anim.SetBool("isMoving", InputManager.I.xAxis != 0);
        anim.SetBool("isWallrunning", !player.isGrounded && player.isOnWall);
    }
}