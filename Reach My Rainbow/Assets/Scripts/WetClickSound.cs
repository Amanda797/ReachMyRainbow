using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WetClickSound : MonoBehaviour
{
    public AudioSource audioSource;

    public AudioClip WetClick;

    public void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
}
