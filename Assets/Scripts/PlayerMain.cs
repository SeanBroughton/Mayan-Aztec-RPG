using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMain : MonoBehaviour
{
    
    [SerializeField] Rigidbody2D playerPhysics;
    [SerializeField] Animator basePlayerAnimator;

    void Start()
    {
        
    }

    
    void Update()
    {
    //Creates 360 Movement for Base Player
        float verticalMovement = Input.GetAxisRaw("Vertical");
        float horizontalMovement = Input.GetAxisRaw("Horizontal");
        playerPhysics.velocity = new Vector2( horizontalMovement, verticalMovement);

    // Connects Player Movement to the the Animator
        basePlayerAnimator.SetFloat("movementX", playerPhysics.velocity.x);
        basePlayerAnimator.SetFloat("movementY", playerPhysics.velocity.y);
    }
}
