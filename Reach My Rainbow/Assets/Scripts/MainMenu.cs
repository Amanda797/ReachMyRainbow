using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void button_Play()
    {
        Debug.Log("You have pressed the Play Button");

        GetComponent<AudioSource>().Play();
    }

    public void CreditButton()
    {
        Debug.Log("You have pressed the Credit Button");

        GetComponent<AudioSource>().Play();
    }

    public void OptionButton()
    {
        Debug.Log("You have pressed the Option Button");

        GetComponent<AudioSource>().Play();
    }

   public void QuitButton()
    {
        Debug.Log("You have pressed the Quit Button");

        GetComponent<AudioSource>().Play();
    }
}
