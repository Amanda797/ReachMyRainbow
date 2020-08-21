using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//to manage scenes
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void LoadNextScene()

    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex + 1);

    }

    void Update()
    {
        if (Input.GetKey("escape"))
        {
            Application.Quit();
        }
    }

    public void OnMouseDown()
    {
        if (GameManager.instance.toContinue == 8)
        {
            LoadNextScene(); 
        }
    }

    public void Options()
    {
        
    }

    public void Credits()
    {

    }

    public void OnApplicationQuit()
    {
        
    }


}
