using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorVerification : MonoBehaviour
{
    

    public GameManager.colorType myColor;

    public Sprite coloredSprite;    

    public AudioSource audiosource;

    public AudioClip Right;

    public AudioClip Wrong;

    public void OnMouseDown()
    {
        if (GameManager.instance.selectedColorType == myColor)
        {
            GetComponent<SpriteRenderer>().sprite = coloredSprite;

            audiosource.clip = Right;
            audiosource.Play();

            GameManager.instance.toContinue++;

            
        }

        else
        {
            audiosource.clip = Wrong;
            audiosource.Play();
        }
    }
}
