using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu_AudioManager : MonoBehaviour
{
    [Header("-------------Audio Sources-------------")]
    [SerializeField] AudioSource MusicSource;

    [SerializeField] AudioSource SFX_Source;

    [Header("-------------Audio Clips-------------")]
    public AudioClip background_Music;
    public AudioClip button_Click_SFX;
    public AudioClip button_Exit_SFX;

    private void Start()
    {
        MusicSource.clip = background_Music;
        MusicSource.Play();
    }

    public void PlaySFX(AudioClip clip)
    {
        SFX_Source.PlayOneShot(clip);
    }
}
