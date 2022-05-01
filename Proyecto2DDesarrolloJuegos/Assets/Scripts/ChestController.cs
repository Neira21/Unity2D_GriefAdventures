using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestController : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            ControladorPuntos.Instance.aumentarPuntosCofres();
            Destroy(gameObject);
            Instantiate(FindObjectOfType<SonidosController>().SonidoCofre);
        }
    }
}
