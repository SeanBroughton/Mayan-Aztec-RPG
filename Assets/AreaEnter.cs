using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AreaEnter : MonoBehaviour
{
   
    [SerializeField] string transitionAreaName;

    void Start()
    {
    // Makes it so the player will enter the new level from the same position they entered it
        if(transitionAreaName == PlayerMain.instance.transitionName)
        {
            PlayerMain.instance.transform.position = transform.position;
        }
    }

    
    void Update()
    {
        
    }
}
