using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AudioManager : MonoBehaviour
{
    public AudioSource coinSoundSrc;

    public void playSound()
    {
        coinSoundSrc.Play();
    }
}
