using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PassLevel : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            //SceneManager.LoadScene(2);
            Scene currentScene = SceneManager.GetActiveScene();

            // Check the current scene
            if (currentScene.name == "1")
            {
                // Load scene 3
                SceneManager.LoadScene(2);
            }
            else if (currentScene.name == "2")
            {
                // Load scene 4
                SceneManager.LoadScene(3);
            }
            else if (currentScene.name == "Gimnasio")
            {
                SceneManager.LoadScene(1);
            }
        }
    }
}

