using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;

[Serializable]
public class Intro : MonoBehaviour
{
    public GameObject logo;
    public AudioClip audioLogo;
    
    public virtual IEnumerator Start()
    {
        logo.SetActive(true); 
        GetComponent<AudioSource>().PlayOneShot(audioLogo); 
        yield return new WaitForSeconds(0.5f);
        
        Application.LoadLevel(1);
    }
}
