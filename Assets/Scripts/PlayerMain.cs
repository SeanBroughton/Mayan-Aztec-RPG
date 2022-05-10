using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMain : MonoBehaviour
{
    public static PlayerMain instance;

    [SerializeField] Rigidbody2D playerPhysics;
    [SerializeField] Animator basePlayerAnimator;
    [SerializeField] int moveSpeed = 1;

    void Start()
    {
    // Creates a singleton pattern that stops the player from duplicating across level changes
        if(instance != null && instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            instance = this;
        }

    //Stops the player from being removed from the game when transitioning between scenes
        DontDestroyOnLoad(gameObject);
    }

    
    void Update()
    {
    //Creates 360 Movement for Base Player
        float verticalMovement = Input.GetAxisRaw("Vertical");
        float horizontalMovement = Input.GetAxisRaw("Horizontal");
        playerPhysics.velocity = new Vector2( horizontalMovement, verticalMovement) * moveSpeed;

    // Connects Player Movement to the the Animator
        basePlayerAnimator.SetFloat("movementX", playerPhysics.velocity.x);
        basePlayerAnimator.SetFloat("movementY", playerPhysics.velocity.y);
    // Controls the Idle Animation to face the right direction when the player stops
        if(horizontalMovement == 1 || horizontalMovement == -1 || verticalMovement == 1 || verticalMovement == -1)
        {
            basePlayerAnimator.SetFloat("LastX", horizontalMovement);
            basePlayerAnimator.SetFloat("LastY", verticalMovement);
        }

    }
}
