using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Score : MonoBehaviour
{
    public TextMeshProUGUI scoreTexto;
    private int score;
    public TextMeshProUGUI scoreChestTexto;
    private int scoreChest;
    // Start is called before the first frame update
    void Awake()
    {
        score = FindObjectOfType<ControladorPuntos>().cantidadMonedas;
        scoreChest = FindObjectOfType<ControladorPuntos>().cantidaCofres;
    }
    void Update()
    {
                
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "moneda")
        {
            score++;
            scoreTexto.text = "x " + score;
        }
        if (collision.gameObject.tag == "cofre")
        {
            scoreChest++;
            scoreChestTexto.text = "x " + scoreChest;
        }
    }
    public void ReiniciarPuntos()
    {
        score = 0;
        scoreChest = 0;
    }

}
