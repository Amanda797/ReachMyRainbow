using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour


{
    public static GameManager instance;
    public Color selectedColor = Color.clear;

    public enum colorType { None, Blue, Yellow, Red, Purple, Green, Orange, Black, White}
    public colorType selectedColorType;

    public int toContinue;

    public ColorMixer colorMixer;


    public void setActiveColor(GameManager.colorType newColorType)
    {
        selectedColorType = newColorType;
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
