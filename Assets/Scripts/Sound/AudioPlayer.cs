using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Sound
{
    [RequireComponent(typeof(AudioSource))]
    public class AudioPlayer : MonoBehaviour, IAudioPlayer
    {
        public bool IsPlaying => source.isPlaying;
        public bool IsDelayed { get; protected set; }

        private AudioSource source;
        private float _delay;

        [SerializeField]
        public BasicSound Sound;

        public bool DelayAfter = false;

        public void Pause()
        {
            IsDelayed = false;
            source.Pause();
        }

        public void Play()
        {
            source.pitch = Sound.Pitch.Read();
            _delay = Sound.Delay.Read();
            if (_delay <= 0)
                source.PlayOneShot(Sound.Clip, Sound.Volume.Read());
            else if(!IsDelayed)
                StartCoroutine("PlayDelay");
        }

        private IEnumerator PlayDelay() 
        {
            IsDelayed = true;
            if(!DelayAfter)
                yield return new WaitForSeconds(_delay);

            if(IsDelayed)
                source.PlayOneShot(Sound.Clip, Sound.Volume.Read());

            if(DelayAfter)
                yield return new WaitForSeconds(_delay);

            IsDelayed = false;
            _delay = 0;
        }

        public void Stop()
        {
            IsDelayed = false;
            source.Stop();
        }

        public void UnPause()
        {
            source.UnPause();
        }

        private void Awake()
        {
            Sound.LoadAudio();
        }

        private void Start()
        {
            source = GetComponent<AudioSource>();
        }

        private void FixedUpdate()
        {
            if (Sound.Loop && !IsPlaying && !IsDelayed)
                Play();
        }
    }
}