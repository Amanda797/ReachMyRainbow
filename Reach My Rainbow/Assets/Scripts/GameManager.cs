using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour


{
    public static GameManager instance;
    public Color selectedColor = Color.clear;

    public enum colorType { Blue, Yellow, Red }
    public colorType selectedColorType;

    public int toContinue;


    public void setActiveColor(string Color)
    {
        switch (Color)
        {
            case "blue":
                selectedColorType = colorType.Blue;
                break;

            case "red":
                selectedColorType = colorType.Red;
                break;

            case "yellow":
                selectedColorType = colorType.Yellow;
                break;
        }
    }

    private void Awake()
    {
        instance = this; 
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
