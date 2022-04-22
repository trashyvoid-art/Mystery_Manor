using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using System;

public class AudioManager : MonoBehaviour
{
    public Audio[] audioArray;

    void Awake()
    {
        foreach (Audio a in audioArray)
        {
            a.source = gameObject.AddComponent<AudioSource>();
            a.source.clip = a.audio;

            
        }
    }

    // Update is called once per frame
    public void Play(string name)
    {
        Audio a = Array.Find(audioArray, audioArray => audioArray.name == name);
        a.source.Play();
    }
}
