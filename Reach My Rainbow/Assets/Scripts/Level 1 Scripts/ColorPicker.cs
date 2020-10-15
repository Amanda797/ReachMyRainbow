using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorPicker : MonoBehaviour

{
    public GameManager.colorType myColor;
    private void OnMouseDown()
    {
        //set the color to use

        GameManager.instance.setActiveColor(myColor);
        if (myColor == GameManager.colorType.Orange || myColor == GameManager.colorType.Green || myColor == GameManager.colorType.Purple)
        {
            Destroy(ColorManager.colormanager.location.colorOnLocation);
            Destroy(ColorManager.colormanager.location2.colorOnLocation);
            ColorManager.colormanager.location.colorType = GameManager.colorType.None;
            ColorManager.colormanager.location2.colorType = GameManager.colorType.None;
        }

    }
    
}
