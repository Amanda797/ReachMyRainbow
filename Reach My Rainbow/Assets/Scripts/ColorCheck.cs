using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorCheck : MonoBehaviour
{
    //this just checks if right color is selected in game manager
    //Then it activates a second image

    public GameObject topImage;



    // Start is called before the first frame update
    void Start()
    {
        //top image starts off
        topImage.SetActive(false);
    }

    private void OnMouseUpAsButton()
    {
       // if (GameManager.instance.selectedColorType == ) { }
    }
}
