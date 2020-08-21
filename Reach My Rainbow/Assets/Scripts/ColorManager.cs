using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ColorManager : MonoBehaviour
{
    public static ColorManager colormanager;

    public ColorMixer location;
    public ColorMixer location2;

    public bool isMixingColor;

    public GameObject orangePrefab;
    public GameObject greenPrefab;
    public GameObject purplePrefab;
    public GameObject redPrefab;
    public GameObject yellowPrefab;
    public GameObject bluePrefab;

    public Transform colorSpawn;

    public GameObject mixedColor;

    private void Start()
    {
        colormanager = this;
    }
    private void Update()
    {
        if (location != null && location2 != null)
        {
            if (!isMixingColor)


            {

                

                if (location.colorType == GameManager.colorType.Red && location2.colorType == GameManager.colorType.Yellow)
                {
                    mixedColor = Instantiate(orangePrefab, colorSpawn.position, colorSpawn.rotation);

                    isMixingColor = true;
                }

                if (location.colorType == GameManager.colorType.Red && location2.colorType == GameManager.colorType.Blue)
                {
                    mixedColor = Instantiate(purplePrefab, colorSpawn.position, colorSpawn.rotation);
                    isMixingColor = true;
                }

                if (location.colorType == GameManager.colorType.Blue && location2.colorType == GameManager.colorType.Yellow)
                {
                    mixedColor = Instantiate(greenPrefab, colorSpawn.position, colorSpawn.rotation);
                    isMixingColor = true;
                }

                if (location.colorType == GameManager.colorType.Blue && location2.colorType == GameManager.colorType.Red)
                {
                    mixedColor = Instantiate(purplePrefab, colorSpawn.position, colorSpawn.rotation);
                    isMixingColor = true;
                }

                if (location.colorType == GameManager.colorType.Yellow && location2.colorType == GameManager.colorType.Red)
                {
                    mixedColor = Instantiate(orangePrefab, colorSpawn.position, colorSpawn.rotation);
                    isMixingColor = true;
                }

                if (location.colorType == GameManager.colorType.Yellow && location2.colorType == GameManager.colorType.Blue)
                {
                    mixedColor = Instantiate(greenPrefab, colorSpawn.position, colorSpawn.rotation);
                    isMixingColor = true;
                }

                if (location.colorType == GameManager.colorType.Red && location2.colorType == GameManager.colorType.Red)
                {
                    mixedColor = Instantiate(redPrefab, colorSpawn.position, colorSpawn.rotation);
                    isMixingColor = true;
                    mixedColor.GetComponent<DragDrop>().canDrag = false;
                }

                if (location.colorType == GameManager.colorType.Blue && location2.colorType == GameManager.colorType.Blue)
                {
                    mixedColor = Instantiate(bluePrefab, colorSpawn.position, colorSpawn.rotation);
                    isMixingColor = true;
                    mixedColor.GetComponent<DragDrop>().canDrag = false;
                }

                if (location.colorType == GameManager.colorType.Yellow && location2.colorType == GameManager.colorType.Yellow)
                {
                    mixedColor = Instantiate(yellowPrefab, colorSpawn.position, colorSpawn.rotation);
                    isMixingColor = true;
                    mixedColor.GetComponent<DragDrop>().canDrag = false;
                }

                
            }
        }
    }

}
