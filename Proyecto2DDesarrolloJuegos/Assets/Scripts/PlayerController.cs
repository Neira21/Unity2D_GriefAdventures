using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class PlayerController : MonoBehaviour
{

    [SerializeField] float Speed;
    [SerializeField] float moreSpeed;
    [SerializeField] float jumpForce;
    [SerializeField] GameObject efecto;


    public TextMeshProUGUI scoreVida;
    
    private Rigidbody2D Rigidbody2D;
    private Animator Animator;
    private int monedas = 0;
    private float horizontal;
    private bool dobleSalto = false;
    private int vida = 5;

    private bool grounded;

    void Start()
    {
        Rigidbody2D = GetComponent<Rigidbody2D>();
        Animator = GetComponent<Animator>();
    }

    //Control de vida, 
    public void DisminuirVida()
    {
        vida--;
        scoreVida.text = "x " + vida;
        Instantiate(FindObjectOfType<SonidosController>().SonidoDaño);
        if (vida <= 0)
        {
            Destroy(gameObject);
            Instantiate(efecto, new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z), transform.rotation);
            Instantiate(FindObjectOfType<SonidosController>().SonidoMuerte);
        }
    }
    public void AumentarMonedas()
    {
        monedas++;
        if (monedas == 5)
        {
            AumentarVida();
            monedas = 0;
        }
    }
    public void AumentarVida()
    {
        vida++;
        scoreVida.text = "x " + vida;
        Instantiate(FindObjectOfType<SonidosController>().SonidoAumentoVida);
    }
    


    void Update()
    {

        Debug.DrawRay(transform.position, Vector3.down * 6f, Color.red);
        if (Physics2D.Raycast(transform.position, Vector3.down, 8f))
        {
            grounded = true;
            dobleSalto = true;
            Animator.SetBool("isOnTheGround", true);
        }
        else
        {
            grounded = false;
        }

        if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow))
        {
            if (grounded)
            {
                Rigidbody2D.velocity = Vector2.zero;
                dobleSalto = true;
                Jump();

            }
            else if (dobleSalto)
            {
                Rigidbody2D.velocity = Vector2.zero;
                Animator.SetBool("isOnTheGround", false);
                Jump();
                dobleSalto = false;
            }

        }
    }

    private void Jump()
    {
        Rigidbody2D.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        Instantiate(FindObjectOfType<SonidosController>().SonidoSalto);
    }



    //Movimiento del personaje
    private void FixedUpdate()
    {
        //Movimiento
        horizontal = Input.GetAxisRaw("Horizontal");
        if (Input.GetKey(KeyCode.LeftShift))
        {
            Rigidbody2D.velocity = new Vector2(horizontal * moreSpeed, Rigidbody2D.velocity.y);
        }
        else
        {
            Rigidbody2D.velocity = new Vector2(horizontal * Speed, Rigidbody2D.velocity.y);
        }
        //Direcci�n
        if (Input.GetAxis("Horizontal") < 0)
        {
            gameObject.GetComponent<SpriteRenderer>().flipX = true;
        }
        if (Input.GetAxis("Horizontal") > 0)
        {

            gameObject.GetComponent<SpriteRenderer>().flipX = false;
        }
        //Animaci�n de movimiento
        if (horizontal != 0)
        {
            Animator.SetBool("isRunning", true);
        }
        else
        {
            Animator.SetBool("isRunning", false);
        }
    }


    

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("agua"))
        {
            Instantiate(FindObjectOfType<SonidosController>().SonidoAgua);
        }
    }

}
