using Unity.VisualScripting;
using UnityEngine;

public class movimientoViejo : MonoBehaviour
{
    Rigidbody2D playerRB;//Variable para el rigidbody de nuestro player
    public float velPlayer;
    // Asi funciona el viejo input, pero despues de esto usaremos
    // solamente el nuevo
    void Start()
    {
       playerRB=GetComponent<Rigidbody2D>(); 
    }

    // Update is called once per frame
    void Update()
    {
        float movimientoH=Input.GetAxis("Horizontal");
        playerRB.linearVelocityX=movimientoH*velPlayer;
    }
}
