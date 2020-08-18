using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorMe : MonoBehaviour
{ 
    public SpriteRenderer spriteRenderer;

    
        
    
    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>(); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseUpAsButton()
    {
        if (GameManager.instance.selectedColor != null) {
            spriteRenderer.color = GameManager.instance.selectedColor;
            GameManager.instance.selectedColor = Color.clear;
        }
    } 
}
