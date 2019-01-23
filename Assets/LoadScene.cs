using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
  
  
    public string sceneToLoad = ("Felix.Sandbox");
   
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
          
            SceneManager.LoadScene(sceneToLoad);
        }
    }
}
