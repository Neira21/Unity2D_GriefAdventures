using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinController : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player")  )
        {
            ControladorPuntos.Instance.aumentarPuntosMonedas();
            Destroy(gameObject);
            FindObjectOfType<PlayerController>().AumentarMonedas();
            Instantiate(FindObjectOfType<SonidosController>().SonidoMoneda);
        }
    }
}
