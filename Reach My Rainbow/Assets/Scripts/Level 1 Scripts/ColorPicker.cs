using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorPicker : MonoBehaviour

{
    public string activeColor;
    private void OnMouseDown()
    {
        //set the color to use

        GameManager.instance.setActiveColor(activeColor);


    }
}
