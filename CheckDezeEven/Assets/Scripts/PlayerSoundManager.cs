﻿using UnityEngine.Audio;
using System;
using UnityEngine;

public class PlayerSoundManager : MonoBehaviour
{
    public Sound[] sounds;

    public static PlayerSoundManager instance;
    public float audioVolume = 0;

    void Awake()
    {

        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
            return;
        }

        DontDestroyOnLoad(gameObject);

        foreach (Sound s in sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;

            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
            s.source.loop = s.loop;
        }
        Play("PlayerTrack");
    }

    public void Play(string name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        if (s == null)
        {
            Debug.LogWarning("Sound: " + name + " aint here?!");
            return;
        }
        s.source.Play();
    }

    //public void ChangeVolume(string name, float _volume)
    //{
    //    Sound s = Array.Find(sounds, sound => sound.name == name);
    //    if (s == null)
    //    {
    //        Debug.LogWarning("Sound: " + name + " aint here?!");
    //        return;
    //    }
    //    s.source.volume = _volume;
    //    //s.source.Volume(_volume);

    //}
}
