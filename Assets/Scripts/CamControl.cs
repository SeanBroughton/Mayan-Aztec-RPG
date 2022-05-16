using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
public class CamControl : MonoBehaviour
{
   
    private PlayerMain playerTarget;
    CinemachineVirtualCamera virtualCamera;

    void Start()
    {
        //Finds the player and assigns the camera to the player. Then follows the player's current position
        playerTarget = FindObjectOfType<PlayerMain>();
        virtualCamera = GetComponent<CinemachineVirtualCamera>();
        virtualCamera.Follow = playerTarget.transform;
    }

  
    void Update()
    {
        
    }
}
