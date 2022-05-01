using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicHistoria : MonoBehaviour
{
    private static AudioSource _audioSource;


    private void Awake()
    {
        if(_audioSource != null)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(this.gameObject);
            _audioSource = GetComponent<AudioSource>();
        }
    }

    public void PLayMusic()
    {
        if (_audioSource.isPlaying) return;
        _audioSource.Play();
    }

    public void StopMusic()
    {
        _audioSource.Stop();
    }

    /*private MusicHistoria instance;

    public MusicHistoria Instance
    {
        get
        {
            return instance;
        }
    }

    private void Awake()
    {
        if (FindObjectsOfType(GetType()).Length > 1)
        {
            Destroy(gameObject);
        }        

        if(instance!=null && instance != this)
        {
            Destroy(gameObject);
            return;
        }
        else
        {
            instance = this;
        }

        DontDestroyOnLoad(gameObject);

    }
    */
}
