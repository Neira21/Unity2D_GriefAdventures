using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuPausa : MonoBehaviour
{
    public static MenuPausa Instance;


    [SerializeField] private GameObject botonPausa;
    [SerializeField] private GameObject menuPausa;

    bool puedePresionarEscape = true;
    // Start is called before the first frame update

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (puedePresionarEscape)
            {
                Pausa();
                puedePresionarEscape = false;
            }
            else
            {
                Reanudar();
                puedePresionarEscape = true;
            }

        }
    }

    public void Pausa()
    {
        Time.timeScale = 0f;
        botonPausa.SetActive(false);
        menuPausa.SetActive(true);
    }
    public void Reanudar()
    {
        Time.timeScale = 1f;
        botonPausa.SetActive(true);
        menuPausa.SetActive(false);
    }

    public void opciones()
    {

    }

    public void Reiniciar()
    {

        if(FindObjectOfType<PlayerController>() != null)
        {
            Time.timeScale = 1f;
            ControladorPuntos.Instance.reiniciarPuntos();
            FindObjectOfType<Score>().ReiniciarPuntos();

            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        else
        {
            SceneManager.LoadScene("Level1");
            Time.timeScale = 1f;
            ControladorPuntos.Instance.cantidadMonedas = 0;
            ControladorPuntos.Instance.cantidaCofres = 0;
        }

        
    }
    public void Cerrar()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainMenu");
    }

    

}
