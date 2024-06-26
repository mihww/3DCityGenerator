using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour
{
    [Header(" * Sources * ")]
    [SerializeField] public AudioSource musicSource;
    [SerializeField] public AudioSource SFXSource;

    [Header(" * Clips * ")]
    public AudioClip bg;
    public AudioClip generate;



    public static AudioManager instance;

    void Awake()
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

    private void Start()
    {
        musicSource.clip = bg;
        musicSource.volume = 1.2f;
        musicSource.Play();
       
      
    }







    public void PlayGenerateSFX()
    {
        Debug.Log("PlayGenerateSFX called");
        if (SFXSource != null && generate != null)
        {
            SFXSource.clip = generate;
            SFXSource.Play();
        }
    }



}
