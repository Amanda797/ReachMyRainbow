using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using UnityEngine;

public class ColorMe_Level2 : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;


    public Sprite Red;
    public Sprite Yellow;
    public Sprite Blue;
    public Sprite Black;
    public Sprite White;
    public Sprite Green;
    public Sprite Orange;
    public Sprite Purple;

    AudioSource audioData;




    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        audioData = GetComponent<AudioSource>();
    }


    private void OnMouseDown()
    {
        if (GameManager.instance.selectedColor != null)
        {
            audioData.Play(0);
            switch (GameManager.instance.selectedColorType)
            {
                case GameManager.colorType.Black:
                    spriteRenderer.sprite = Black;
                    break;
                case GameManager.colorType.White:
                    spriteRenderer.sprite = White;
                    break;
                case GameManager.colorType.Red:
                    spriteRenderer.sprite = Red;
                    break;
                case GameManager.colorType.Blue:
                    spriteRenderer.sprite = Blue;
                    break;
                case GameManager.colorType.Yellow:
                    spriteRenderer.sprite = Yellow;
                    break;
                case GameManager.colorType.Green:
                    spriteRenderer.sprite = Green;
                    break;
                case GameManager.colorType.Orange:
                    spriteRenderer.sprite = Orange;
                    break;
                case GameManager.colorType.Purple:
                    spriteRenderer.sprite = Purple;
                    break;
                case GameManager.colorType.None:
                    break;

            }
        }
    }
}
