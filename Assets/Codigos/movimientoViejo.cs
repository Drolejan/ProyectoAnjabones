using Unity.VisualScripting;
using UnityEngine;

public class movimientoViejo : MonoBehaviour
{
    Rigidbody2D playerRB;//Variable para el rigidbody de nuestro player
    public float velPlayer;
    public float velSalto;
    public GameObject bala; //El objeto que vamos a disparar
    // Asi funciona el viejo input, pero despues de esto usaremos
    void Start()
    {
       playerRB=GetComponent<Rigidbody2D>(); 
    }

    // Update is called once per frame
    void Update()
    {
        float movimientoH=Input.GetAxis("Horizontal");
        playerRB.linearVelocityX=movimientoH*velPlayer;

        if (Input.GetButtonDown("Jump"))
        {
            playerRB.AddForceY(velSalto,ForceMode2D.Impulse);
        }

        if (Input.GetButtonDown("Fire1"))
        {
            GameObject estaBala=Instantiate(bala,transform.position,Quaternion.identity);
            Rigidbody2D balaRB=estaBala.GetComponent<Rigidbody2D>();
            balaRB.AddForceX(50,ForceMode2D.Impulse);
        }
    }
}
