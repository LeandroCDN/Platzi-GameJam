using UnityEngine;
using UnityEngine.Audio;
using System;

public class AudioManager : MonoBehaviour
{
    public Sound[] sounds;

    void Awake()
    {
        foreach (Sound s in sounds) 
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;

            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
            s.source.loop = s.loop;
        }
    }
    private void Start()
    {
        Play("lento");
        Play("medio");
        Play("rapido");
    }

    void Update()
    {
        if(UIManager.uiManager.timeStart > 9)
        {
            Ruido("lento");

        }
        else
        {
            Silence("lento");
        }
        if((UIManager.uiManager.timeStart > 4) && (UIManager.uiManager.timeStart < 10))
        {
            Ruido("medio");

        }
        else
        {
            Silence("medio");
        }
        if ((UIManager.uiManager.timeStart < 5) )
        {
            Ruido("rapido");

        }
        else
        {
            Silence("rapido");
        }
    }


    public void Play (string name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        s.source.Play();
    }

    public void Silence(string name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        s.source.volume = 0;
    }
    public void Ruido(string name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        if (s == null)
        {
            Debug.LogWarning("Sound :" + name + " not found!");
            return;
        }
        s.source.volume = 0.8f;
    }
}
