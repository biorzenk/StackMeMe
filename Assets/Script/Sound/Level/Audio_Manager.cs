using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio_Manager : MonoBehaviour
{
    public static Audio_Manager Instance;

    [Header("-------------Audio Sources-------------")]
    [SerializeField] AudioSource MusicSource;

    [SerializeField] AudioSource SFXSource;

    [Header("-------------Audio Clips-------------")]
    public AudioClip level_Music;
    public AudioClip _playerDead;
    public AudioClip _playerJump;

    private void Awake()
    {
        Instance = this;
        MusicSource.clip = level_Music;
        MusicSource.Play();
    }


    public void PlaySFX(AudioClip clip)
    {
        if (clip == null || SFXSource == null) return;
        SFXSource.PlayOneShot(clip);
    }
}
