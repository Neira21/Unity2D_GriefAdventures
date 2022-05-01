using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private GameObject panelOpciones;
    [SerializeField] private GameObject panelMenuInicio;
    [SerializeField] private GameObject panelCreditos;

    public void EscenaJuego()
    {
        if (FindObjectOfType<ControladorPuntos>() != null)
        {
            ControladorPuntos.Instance.cantidadMonedas = 0;
            ControladorPuntos.Instance.cantidaCofres = 0;
        }
        SceneManager.LoadScene("Level1");
    }

    public void HistoriaJuego()
    {
        SceneManager.LoadScene("Historia1");
    }


    public void Opciones()
    {
        panelOpciones.SetActive(true);
        panelMenuInicio.SetActive(false);
    }

    public void Creditos()
    {
        panelCreditos.SetActive(true);
        panelMenuInicio.SetActive(false);
    }



    public void Salir()
    {
        Application.Quit();
    }



}
