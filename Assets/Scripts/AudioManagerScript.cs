using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AudioManagerScript : MonoBehaviour
{
    [SerializeField] AudioSource bgmSource;

    public AudioClip background;

    public static AudioManagerScript instance;

    [SerializeField] private AudioMixer _audioMixer;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    // Start is called before the first frame update
    void Start()
    {

        _audioMixer.SetFloat("Music", Mathf.Log10(0.5f) * 20);
        bgmSource.clip = background;
        bgmSource.Play();
    }


    public void StopBGM()
    {
        bgmSource.clip = background;
        bgmSource.Stop();
    }
}
