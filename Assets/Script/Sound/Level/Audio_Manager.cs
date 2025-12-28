using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio_Manager : MonoBehaviour
{

    [Header("-------------Audio Sources-------------")]
    [SerializeField] AudioSource MusicSource;

    [SerializeField] AudioSource SFXSource;

    [Header("-------------Audio Clips-------------")]
    public AudioClip level_Music;

    void Start()
    {
        MusicSource.clip = level_Music;
        MusicSource.Play();
    }
}
