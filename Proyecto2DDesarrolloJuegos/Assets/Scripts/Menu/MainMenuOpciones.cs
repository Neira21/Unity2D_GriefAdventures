using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuOpciones : MonoBehaviour
{
    [SerializeField] private GameObject panelOpciones;
    [SerializeField] private GameObject panelMenuInicio;
    public void RegresarMenuPrincipal()
    {
        panelOpciones.SetActive(false);
        panelMenuInicio.SetActive(true);
    }
}
