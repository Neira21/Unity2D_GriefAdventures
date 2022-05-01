using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class NivelCompletado : MonoBehaviour
{
    GameObject coleccionMonedas;
    GameObject coleccionCofres;
    public GameObject mensaje;

    private void Start()
    {
        coleccionMonedas = GameObject.FindGameObjectWithTag("CollectMoneda");
        coleccionCofres = GameObject.FindGameObjectWithTag("CollectCofre");
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            if (coleccionCofres.transform.childCount == 0 && coleccionMonedas.transform.childCount == 0)
            {
                int escenaActual = SceneManager.GetActiveScene().buildIndex;
                SceneManager.LoadScene(escenaActual+1);
            }
            else
            {
                mensaje.SetActive(true);
                Debug.Log("Falta encontrar monedas o cofres");
            }
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            mensaje.SetActive(false);
        }
    }
}
