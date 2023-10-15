using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public PlayerController playerController;

    [SerializeField] float _moveSpeed = 5f;
    float horizontalMove = 0f;

    bool isJumping = false; 

    // Update is called once per frame
    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * _moveSpeed;

        if(Input.GetButtonDown("Jump"))
        {
            isJumping = true;
        }
    }

    private void FixedUpdate()
    {
        playerController.Move(horizontalMove * Time.fixedDeltaTime, false, isJumping);
        isJumping = false;



    }
}
