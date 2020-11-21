using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorVerification : MonoBehaviour
{
    

    public GameManager.colorType myColor;

    public Sprite coloredSprite;    

    public AudioSource audiosource;

    public AudioClip Right;

    public AudioClip RightVoice;

    public AudioClip Wrong;

    public AudioClip WrongVoice;

    public float rightPauseTime = 2; //Set delay time to allow first clip to finish before right clip
    public float wrongPauseTime = 2; //Set delay time to allow first clip to finish before wrong clip


    public void OnMouseDown()
    {
        if (GameManager.instance.selectedColorType == myColor)
        {
            GetComponent<SpriteRenderer>().sprite = coloredSprite;

            audiosource.clip = Right;
            audiosource.Play();


            GameManager.instance.toContinue++;

            StartCoroutine(RightPause()); //Pauses script then plays correct clip


        }

        else
        {
            audiosource.clip = Wrong;
            audiosource.Play();

            StartCoroutine(WrongPause()); //Pauses script then plays the wrong clip
        }
    }

    //Coroutine to allow a delay audio between ding and right sound
    IEnumerator RightPause()
    {
        yield return new WaitForSeconds(rightPauseTime);

        //Changes clip to right voice then plays
        audiosource.clip = RightVoice;
        audiosource.Play();
    }

    //Coroutine to allow a delay audio between ding and wrong sound
    IEnumerator WrongPause()
    {
        yield return new WaitForSeconds(wrongPauseTime);

        //Changes clip to wrong voice then plays
        audiosource.clip = WrongVoice;
        audiosource.Play();
    }
}
