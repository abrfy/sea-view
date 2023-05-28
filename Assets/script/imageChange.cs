using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class imageChange : MonoBehaviour
{
    public Sprite OnImage;
    public Sprite OffImage;
    private bool isSoundOn = true;
    public Button SoundButton;
    soundmanager soundManager;
    public AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        soundManager = FindObjectOfType<soundmanager>();
        audioSource = soundManager.GetComponent<AudioSource>();
        OnImage = SoundButton.image.sprite;
    }

    // Update is called once per frame

    public void OnButtonPress()
    {
        if (isSoundOn)
        {
            SoundButton.image.sprite = OffImage;
            isSoundOn = false;
            audioSource.mute = true;
        }
        else
        {
            SoundButton.image.sprite = OnImage;
            isSoundOn = true;
            audioSource.mute = false;
        }
    }
}
