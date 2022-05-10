using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AreaExit : MonoBehaviour
{
   
    [SerializeField] string sceneToLoad;
    [SerializeField] string areaExitTransitionName;

    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    //Allows the player to trigger an Area Exit to leave the current Scene
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            PlayerMain.instance.transitionName = areaExitTransitionName;
            SceneManager.LoadScene(sceneToLoad);
        }
    }
}
