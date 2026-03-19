using UnityEngine;
using UnityEngine.InputSystem;

public class movimientoNuevo : MonoBehaviour
{
    Rigidbody2D playerRB;//Variable para el rigidbody de nuestro player
    public float velPlayer;
    public float velSalto;
    public GameObject bala; //El objeto que vamos a disparar
    public float balaSpeed;
    PlayerInput controles;
    int direction=1;//Volteando a la izquierda
    public Transform origenDisparo;
    void Start()
    {
       playerRB=GetComponent<Rigidbody2D>(); 
       controles=GetComponent<PlayerInput>();
    }

    // Update is called once per frame
    void Update()
    {
        float movimientoH=controles.actions["Move"].ReadValue<Vector2>().x;
        playerRB.linearVelocityX=movimientoH*velPlayer;

        if (movimientoH > 0)
        {
            direction=-1;
            transform.localScale=new Vector2(direction,transform.localScale.y);
        }
        else if (movimientoH < 0)
        {
            direction=1;
            transform.localScale=new Vector2(direction,transform.localScale.y);
        }

        if (controles.actions["Jump"].WasPressedThisFrame())
        {
            playerRB.AddForceY(velSalto,ForceMode2D.Impulse);
        }

        if (controles.actions["Attack"].WasPressedThisFrame())
        {
            GameObject estaBala=Instantiate(bala,origenDisparo.position,Quaternion.identity);
            Rigidbody2D balaRB=estaBala.GetComponent<Rigidbody2D>();
            balaRB.AddForceX(balaSpeed*-direction,ForceMode2D.Impulse);
            Destroy(estaBala,2f);//Despues de 2 seg se destruye la bala 
        }
    }
}
