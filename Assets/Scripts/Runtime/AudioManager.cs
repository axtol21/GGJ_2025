using System.Collections.Generic;
using System.Drawing;
using NUnit.Framework;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [Header("---------- Audio Source ----------")]

    [SerializeField] private AudioSource musicSource;
    [SerializeField] private AudioSource SFXSource;

    [Header("---------- AudioClips ----------")]

    [SerializeField] private AudioClip roundMusic;
    [SerializeField] private AudioClip shopMusic;
    [SerializeField] private AudioClip menuMusic;
    
    [SerializeField] private AudioClip damageTaken;
    [SerializeField] private AudioClip warning;

    [SerializeField] private AudioClip enterLevel;
    [SerializeField] private AudioClip exitLevel;

    [SerializeField] private List<AudioClip> bubblePops;

    public static AudioManager Instance;

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(Instance);
        }
        Instance = this;
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SetMenuMusic();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetRoundMusic()
    {
        SFXSource.PlayOneShot(enterLevel);
        musicSource.clip = roundMusic;
        musicSource.Play();
    }

    public void SetShopMusic()
    {
        SFXSource.PlayOneShot(exitLevel);
        musicSource.clip = shopMusic;
        musicSource.Play();
    }

    public void SetMenuMusic()
    {
        SFXSource.PlayOneShot(exitLevel);
        musicSource.clip = menuMusic;
        musicSource.Play();
    }

    public void CloseToPopSFX()
    {
        SFXSource.PlayOneShot(warning);
    }

    public void TakeDamageSFX()
    {
        SFXSource.PlayOneShot(damageTaken);
    }

    //public void EnterLevelSFX()
    //{
    //    SFXSource.PlayOneShot(enterLevel);
    //}

    //public void ExitLe

    public void BubblePopSFX()
    {
        SFXSource.PlayOneShot(bubblePops[Random.Range(0, bubblePops.Count)]);
    }

}
