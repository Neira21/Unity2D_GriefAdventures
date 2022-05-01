using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControladorPuntos : MonoBehaviour
{
    public static ControladorPuntos Instance;
    [SerializeField] public int cantidadMonedas;
    [SerializeField] public int cantidaCofres;
    private void Awake()
    {
        if(ControladorPuntos.Instance == null)
        {
            ControladorPuntos.Instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    public void aumentarPuntosMonedas()
    {
        cantidadMonedas++;
    }
    public void aumentarPuntosCofres()
    {
        cantidaCofres++;
    }
    public void reiniciarPuntos()
    {
        if (SceneManager.GetActiveScene().name == "Level1")
        {
            cantidadMonedas = 0;
            cantidaCofres = 0;
        }
        else if (SceneManager.GetActiveScene().name == "Level2")
        {
            cantidadMonedas = 15;
            cantidaCofres = 3;
        }
        else if(SceneManager.GetActiveScene().name == "Level3")
        {
            cantidadMonedas = 25;
            cantidaCofres = 6;
        }
    }
}
