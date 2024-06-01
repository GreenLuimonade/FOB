using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class VolumenSettings : MonoBehaviour
{
    public AudioMixer audio;
    public Slider sliderMusica;
    public Slider sliderSFX;
    private void Start()
    {
        sliderMusica.value = PlayerPrefs.GetFloat("MusicVolume");
        sliderSFX.value = PlayerPrefs.GetFloat("SFXVolume");
        setmusicVol();
        setVFXVol();

    }
    public void setmusicVol() 
    {
        float volM = sliderMusica.value;
        audio.SetFloat("MusicVol", Mathf.Log10(volM)*20);
        PlayerPrefs.SetFloat("MusicVolume", volM);
    }
    public void setVFXVol()
    {
        float volS = sliderSFX.value;
        audio.SetFloat("SFXVol", Mathf.Log10(volS) * 20);
        PlayerPrefs.SetFloat("SFXVolume", volS);

    }
}
