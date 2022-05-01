using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicaPlay : MonoBehaviour
{
    // Start is called before the first frame update
    public void Start()
    {
        GameObject.FindGameObjectWithTag("ControllerMusic").GetComponent<MusicHistoria>().PLayMusic();
    }
}
