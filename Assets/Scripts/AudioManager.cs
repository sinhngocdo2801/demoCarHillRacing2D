using UnityEngine.Audio;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

//public enum SoundType
//{
//    button = 0,
//    win = 1,
//}

//public enum MusicType
//{
//    main_0 = 0,
//    main_1 = 1,
//    main_2 = 2,
//    main_menu = 3,
//    AMB = 4,
//}
public class AudioManager : MonoBehaviour
{
    public Sound[] sounds;

    [SerializeField] Slider volumeSlider;

    private void Awake()
    {
        foreach (Sound s in sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;

            s.source.volume = s.volume;
            s.source.pitch = s.pitch;

            s.source.loop = s.loop;
        }

        //if( volumeSlider == null)
        //{
        //    //volumeSlider = this;
        //    DontDestroyOnLoad(volumeSlider);
        //}
        //else
        //{
        //    Destroy(this);
        //}
    }

    private void Start()
    {
        Play("AMB");

        Play("main_2");

        if (!PlayerPrefs.HasKey("musicVolume"))
        {
            PlayerPrefs.SetFloat("musicVolume", 1);
            Load();
        }
        else
        {
            Load();
        }
    }

    public void changeVolume()
    {
        AudioListener.volume = volumeSlider.value;
    }




    private void Load()
    {
        volumeSlider.value = PlayerPrefs.GetFloat("musicVolume");
    }

    void Save()
    {
        PlayerPrefs.SetFloat("musicVolume", volumeSlider.value);
    }


    public void Play( string name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        if(s == null)
        {
            //Debug.LogWarning("Sound: " + name + "not found.");
            return;
        }
        s.source.Play();
    }


    /*
    public static AudioManager instance;

    public AudioSource audioFx;



    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
            DontDestroyOnLoad(instance);
        }
        else
        {
            Destroy(this);
        }
    }

    private void OnValidate()
    {
        if(audioFx == null)
        {
            audioFx = gameObject.AddComponent<AudioSource>();
            audioFx.playOnAwake = false; 
        }
    }

    public void OnPlaySound(SoundType soundType)
    {
        var audio = Resources.Load<AudioClip>($"Sound/{soundType.ToString()}");
        audioFx.clip = audio;
        audioFx.Play();
    }

    public void OnPlayMusic(MusicType musicType)
    {
        var audio = Resources.Load<AudioClip>($"Music/{musicType.ToString()}");
        audioFx.loop = true;
        audioFx.clip = audio;
        audioFx.Play();
    }*/

}
