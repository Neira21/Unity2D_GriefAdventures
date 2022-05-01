using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Credits : MonoBehaviour
{
    [SerializeField] private GameObject panelMenuInicio;
    [SerializeField] private GameObject panelCreditos;
    public void IrInicio()
    {
        panelCreditos.SetActive(false);
        panelMenuInicio.SetActive(true);
    }
}
