using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TextoCanvas : MonoBehaviour
{

    //string frase = "Érase una vez, una pequeña criatura cuidando de su familia. Todos los días salía a buscar comida para sus hijos y todos vivían felices. Pero guardaba un oscuro secreto.";
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
            "Había una vez, una pequeña criatura de nombre Grief. Vivía en el campo con su familia y todos eran felices. ",
            "Pero ocurrió algo terrible. Uno de sus hijos se enfermó, tenían que tomar acciones inmediatas para poder sanarlo.",
            "No hubo mas opción que ir al pueblo en busca de ayuda, por lo que necesitaban reunir una gran cantidad de dinero.",
            "Entrando en un bosque peligroso inició camino a su aventura para salvar a su hijo, sin importar nada más",
            "LUEGO DE LA GRAN TRAVESÍA DE GRIEF, AL LLEGAR A CASA PARA VER A SU HIJO, YA ERA DEMASIADO TARDE..."
        };


        TextWriter.AddWriter_static(texto, MessageArrays[numeroTexto], .05f, true);
        
       
    }

    


    //private void Start()
    //{
    //    //texto.SetText("Hello World");
        
    //    //TextWriter.AddWriter_static(texto, "de su familia. Todos los días salía a buscar comida para sus hijos y todos vivían felices. Pero guardaba un oscuro secreto.", .1f, true);
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
