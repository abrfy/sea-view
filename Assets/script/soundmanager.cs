using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundmanager : MonoBehaviour
{
    // Start is called before the first frame update
    public static soundmanager instance;
    private soundmanager[] soundManagers;
    public bool isMuted = false;
    private AudioSource audioSource;
    void Awake()
    {
        int soundManagerCount = FindObjectsOfType<soundmanager>().Length;
        if (soundManagerCount > 1)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
            audioSource = GetComponent<AudioSource>();
        }
    }
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        UpdateAudioSource();
        PlaySound();
        soundmanager[] soundManagers = FindObjectsOfType<soundmanager>();
        if (soundManagers.Length > 1)
        {
            for (int i = 1; i < soundManagers.Length; i++)
            {
                Destroy(soundManagers[i].gameObject);
            }
        }
        DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    public void PlaySound()
    {
        GetComponent<AudioSource>().Play();
    }
    private void UpdateAudioSource()
    {
        if (isMuted)
        {
            audioSource.volume = 0;
        }
        else
        {
            audioSource.volume = 1;
        }
    }
    public void ToggleMute()
    {
        isMuted = !isMuted;
        UpdateAudioSource();
    }

    //void Awake()
    //{
    //    if (instance == null)
    //    {
    //        instance = this;
    //        DontDestroyOnLoad(gameObject);
    //    }
    //    else
    //    {
    //        Destroy(gameObject);
    //    }
    //}
}
