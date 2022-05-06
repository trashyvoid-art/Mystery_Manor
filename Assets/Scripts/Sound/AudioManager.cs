using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using System;

public class AudioManager : MonoBehaviour
{
    public Audio[] audioArray;
    GameObject playerObject;
    Vector3 playerPos;

    void Awake()
    {
        playerObject = GameObject.Find("Player");
        //foreach (Audio a in audioArray)
        //{
        //    //find way to create on talk w/ character

        //    //currently makes audiosource for each audio in array on start
        //    //a.source = gameObject.AddComponent<AudioSource>();
        //    //a.source.clip = a.audio;
            
        //    //find way to destroy audio source
        //}
    }

    // Plays ClipAtPoint so that Unity handles creating and deleting audio sorces upon talking to an NPC
    public void Play(string name)
    {
        playerPos = playerObject.transform.position;
        Audio a = Array.Find(audioArray, audioArray => audioArray.name == name);
        AudioSource.PlayClipAtPoint(a.audio, playerPos);
    }
}
