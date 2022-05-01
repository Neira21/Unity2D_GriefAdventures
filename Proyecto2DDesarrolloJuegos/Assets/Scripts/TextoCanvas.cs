using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TextoCanvas : MonoBehaviour
{

    //string frase = "�rase una vez, una peque�a criatura cuidando de su familia. Todos los d�as sal�a a buscar comida para sus hijos y todos viv�an felices. Pero guardaba un oscuro secreto.";
    //public TextMeshProUGUI texto;
    private TextMeshProUGUI texto;
    [SerializeField] int numeroTexto;
    //private string[] MessageArrays;

    private void Start()
    {
        texto = transform.Find("Message").Find("Texto1").GetComponent<TextMeshProUGUI>();
        Application.targetFrameRate = 10;
        
        string[] MessageArrays = new string[]
        {
            "Hab�a una vez, una peque�a criatura de nombre Grief. Viv�a en el campo con su familia y todos eran felices. ",
            "Pero ocurri� algo terrible. Uno de sus hijos se enferm�, ten�an que tomar acciones inmediatas para poder sanarlo.",
            "No hubo mas opci�n que ir al pueblo en busca de ayuda, por lo que necesitaban reunir una gran cantidad de dinero.",
            "Entrando en un bosque peligroso inici� camino a su aventura para salvar a su hijo, sin importar nada m�s",
            "LUEGO DE LA GRAN TRAVES�A DE GRIEF, AL LLEGAR A CASA PARA VER A SU HIJO, YA ERA DEMASIADO TARDE..."
        };


        TextWriter.AddWriter_static(texto, MessageArrays[numeroTexto], .05f, true);
        
       
    }

    


    //private void Start()
    //{
    //    //texto.SetText("Hello World");
        
    //    //TextWriter.AddWriter_static(texto, "de su familia. Todos los d�as sal�a a buscar comida para sus hijos y todos viv�an felices. Pero guardaba un oscuro secreto.", .1f, true);
    //    //StartCoroutine(Reloj());
    //}

    /*IEnumerator Reloj()
    {
        foreach(char caracter in frase)
        {
            texto.text = texto.text + caracter;
            yield return new WaitForSeconds(0.06f);
        }
        
    }*/


}
