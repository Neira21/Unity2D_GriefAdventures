using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetenerMusica : MonoBehaviour
{
    void Start()
    {
        GameObject.FindGameObjectWithTag("ControllerMusic").GetComponent<MusicHistoria>().StopMusic();
    }
}
