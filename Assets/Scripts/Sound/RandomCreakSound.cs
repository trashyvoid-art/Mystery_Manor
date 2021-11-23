using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Sound 
{
    [RequireComponent(typeof(AudioPlayer))]
    public class RandomCreakSound : MonoBehaviour
    {
        public AudioSource source;
        private AudioPlayer player;
        public float minWaitBetweenPlays = 5f;
        public float maxWaitBetweenPlays = 10f;
        public float waitTimeCountdown = -1f;


        void Start()
        {
            source = GetComponent<AudioSource>();
            player = GetComponent<AudioPlayer>();
            player.enabled = true;
            player.DelayAfter = true;
        }

        void Update()
        {
            if (!source.isPlaying)
            {
                if (waitTimeCountdown < 0f)
                {
                    string newAudioMap = $"Environment/Creaks";
                    player.Sound.LoadAudio(newAudioMap);
                    player.Play();

                    waitTimeCountdown = Random.Range(minWaitBetweenPlays, maxWaitBetweenPlays);
                }
                else
                {
                    waitTimeCountdown -= Time.deltaTime;
                }
            }
        }
    }
}

