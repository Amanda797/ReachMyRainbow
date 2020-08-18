using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorSetter : MonoBehaviour
{
    public Color colorToUse = Color.white;
    public SpriteRenderer spriteRenderer;

    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.color = colorToUse;
    }

    public void OnMouseUpAsButton()
    {
        GameManager.instance.selectedColor = colorToUse;
    }
}
