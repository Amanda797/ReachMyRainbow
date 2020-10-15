using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonClickSound : MonoBehaviour
{
    public AudioSource audioSource;

    public AudioClip ButtonClick;

    public void Start() 
    {
        audioSource = GetComponent<AudioSource>();
    }
}
