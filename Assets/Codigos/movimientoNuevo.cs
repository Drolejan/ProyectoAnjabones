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

        if (controles.actions["Jump"].WasPressedThisFrame())
        {
            playerRB.AddForceY(velSalto,ForceMode2D.Impulse);
        }

        if (controles.actions["Attack"].WasPressedThisFrame())
        {
            GameObject estaBala=Instantiate(bala,transform.position,Quaternion.identity);
            Rigidbody2D balaRB=estaBala.GetComponent<Rigidbody2D>();
            balaRB.AddForceX(balaSpeed,ForceMode2D.Impulse);
        }
    }
}
