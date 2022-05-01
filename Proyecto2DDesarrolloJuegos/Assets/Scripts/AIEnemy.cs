using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIEnemy : MonoBehaviour
{
    [SerializeField] Transform player;
    [SerializeField] float rangoApro;


    public float velocidadMov;
    Rigidbody2D Rigidbody2D;
    
    
    void Start()
    {
        Rigidbody2D = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        if (player != null)
        {
            float disJugador = Vector2.Distance(transform.position, player.position);
            Debug.Log("Distancia del jugador " + disJugador);

            if (disJugador < rangoApro)
            {
                PerseguirJugador();
            }
            else
            {
                NoPerseguir();
            }
        }
        
    }

    void PerseguirJugador()
    {
        if(transform.position.x < player.position.x)
        {
            Rigidbody2D.velocity = new Vector2(velocidadMov, 0);
        }
        else if(transform.position.x > player.position.x)
        {
            Rigidbody2D.velocity = new Vector2(-velocidadMov, 0);
        }
    }

    void NoPerseguir()
    {
        Rigidbody2D.velocity = Vector2.zero;
    }

}
