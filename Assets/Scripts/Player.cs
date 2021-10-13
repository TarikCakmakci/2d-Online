﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : Photon.MonoBehaviour
{
    public PhotonView photonView;
    public Rigidbody2D rb;
    public GameObject PlayerCamera;
    public Text PlayerNameText;
    public SpriteRenderer sr;

    public bool IsGrounded = false;
    public float MoveSpeed;
    public float JumpForce;


    private void Awake()
    {
        if(photonView.isMine)
        {
            PlayerCamera.SetActive(true);
        }
    }

    private void Update()
    {
        if(photonView.isMine)
        {
            CheckInput();
        }
    }

    private void CheckInput()
    {
        var move = new Vector3(Input.GetAxisRaw("Horizontal"), 0);
        transform.position += move * MoveSpeed * Time.deltaTime;

        if (Input.GetKeyDown(KeyCode.A))  
        {
            sr.flipX = true;
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            sr.flipX = false;
        }
    }


}