using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AreaExit : MonoBehaviour
{
   
    [SerializeField] string sceneToLoad;

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
            SceneManager.LoadScene(sceneToLoad);
        }
    }
}
