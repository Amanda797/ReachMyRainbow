using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragDrop : MonoBehaviour
{

    public GameObject colorPrefab;

    public Transform location;

    public Transform location2;

    private GameObject colorDrag;

    public bool canDrag;

    private void Start()
    {

    }
    private void OnMouseDown()
    {
        if (canDrag)
        {
            GameObject newColor = Instantiate(colorPrefab);
            newColor.transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            colorDrag = newColor;
            colorDrag.GetComponent<DragDrop>().canDrag = false;
        }
    }

    private void OnMouseDrag()
    {

        if (canDrag)
        {
            Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            colorDrag.transform.position = new Vector3(mousePosition.x, mousePosition.y, 0); 
        }


    }

    private void OnMouseUp()
    {
        if (canDrag == true)

        {
            if (Vector3.Distance(colorDrag.transform.position, location.position) < .25f)
            {
                if (ColorManager.colormanager.mixedColor != null)
                {
                    Destroy(ColorManager.colormanager.mixedColor);
                    ColorManager.colormanager.mixedColor = null;
                    ColorManager.colormanager.isMixingColor = false;


                }

                if (location.gameObject.GetComponent<ColorMixer>().colorOnLocation != null)
                {
                    Destroy(location.gameObject.GetComponent<ColorMixer>().colorOnLocation);
                }
                colorDrag.transform.position = location.position;
                location.gameObject.GetComponent<ColorMixer>().colorType = colorDrag.GetComponent<ColorPicker>().myColor;
                location.gameObject.GetComponent<ColorMixer>().colorOnLocation = colorDrag;



            }
            else if (Vector3.Distance(colorDrag.transform.position, location2.position) < .25f)
            {
                if (ColorManager.colormanager.mixedColor != null)
                {
                    Destroy(ColorManager.colormanager.mixedColor);
                    ColorManager.colormanager.mixedColor = null;
                    ColorManager.colormanager.isMixingColor = false;

                }

                if (location2.gameObject.GetComponent<ColorMixer>().colorOnLocation != null)
                {
                    Destroy(location2.gameObject.GetComponent<ColorMixer>().colorOnLocation);
                }
                colorDrag.transform.position = location2.position;
                location2.gameObject.GetComponent<ColorMixer>().colorType = colorDrag.GetComponent<ColorPicker>().myColor;
                location2.gameObject.GetComponent<ColorMixer>().colorOnLocation = colorDrag;



            }
            else
            {
                Destroy(colorDrag);
            } 
        }
    }
}
