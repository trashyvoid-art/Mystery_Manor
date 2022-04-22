using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

[System.Serializable]
public class Audio
{
    public string name;

    public AudioClip audio;

    [HideInInspector]
    public AudioSource source;
}
