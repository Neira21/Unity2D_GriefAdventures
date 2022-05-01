using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TimeController : MonoBehaviour
{
    [SerializeField] int min, seg;
    [SerializeField] TextMeshProUGUI tiempo;

    private float restante;
    private bool enMarcha;

    void Awake()
    {
        restante = (min * 60) + seg;
        enMarcha = true;
    }
    void Update()
    {
        if (enMarcha)
        {
            restante -= Time.deltaTime;
            if (restante < 1)
            {
                enMarcha = false;
                //Matar al player
                Destroy(GameObject.FindGameObjectWithTag("Player"));
                Instantiate(FindObjectOfType<SonidosController>().SonidoMuerte);

            }
            int tempMin = Mathf.FloorToInt(restante / 60);
            int tempSeg = Mathf.FloorToInt(restante % 60);
            tiempo.text = string.Format("{00:00}:{01:00}", tempMin, tempSeg);
        }   
    }
}
