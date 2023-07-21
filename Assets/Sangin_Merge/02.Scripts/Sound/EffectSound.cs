using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectSound : MonoBehaviour
{
    public static EffectSound instance;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
    AudioSource audioSource;
    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void TouchSoundPlay()
    {
        audioSource.PlayOneShot(SoundList.soundList.uiTouchSound);
    }
    public void CrackingSoundPlay()
    {
        audioSource.PlayOneShot(SoundList.soundList.crackingSound);
    }
}
