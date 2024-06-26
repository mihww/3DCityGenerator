using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    [Header(" * Toggle Music Btn * ")]
    public Sprite onSprite;
    public Sprite offSprite;
    public Button btn;

    public void GenerateCity()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        if (AudioManager.instance != null)
        {
            AudioManager.instance.PlayGenerateSFX();
            
        }

    }


    public void MusicToggle()
    {
        var musicSource = AudioManager.instance.musicSource;
        if (musicSource.isPlaying)
        {
            btn.image.sprite = offSprite;
            musicSource.Pause();

        }
        else
        {
            Debug.Log("Unpause msc");
            btn.image.sprite = onSprite;
            musicSource.UnPause();
        }

    }


}
