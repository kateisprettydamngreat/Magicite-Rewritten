using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;

[Serializable]
public class MusicBox : MonoBehaviour
{
    private const string ResourcesPath = "Resources";
    
    private AudioSource audioSource;
    public AudioClip CurTune { get; private set; }

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void PlayTune(AudioClip clip)
    {
        CurTune = clip;
        audioSource.clip = clip;
        audioSource.Play();
    }

    public AudioClip GetRandomTownTune()
    {
        return LoadTune(UnityEngine.Random.Range(10, 13).ToString());
    }
    
    public AudioClip GetBiomeTune(int biome)
    {
        return LoadTune(biome.ToString()); 
    }

    private AudioClip LoadTune(string name)
    {
        return (AudioClip)Resources.Load(Path.Combine(ResourcesPath, "tune", name));
    }
    
    public void SetTownTune()
    {
        PlayTune(GetRandomTownTune());
    }

    public void SetBiomeTune(int biome)
    {
        PlayTune(GetBiomeTune(biome));
    }
}