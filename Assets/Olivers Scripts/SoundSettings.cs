using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SoundSettings : MonoBehaviour
{
    public AudioMixer audioMixer;
    public void SetVolume (float volume)
    {
        audioMixer.SetFloat("Volume", Mathf.Log10(volume) * 20); //Ändrar volymen op main audioMixern. 
    }
}
