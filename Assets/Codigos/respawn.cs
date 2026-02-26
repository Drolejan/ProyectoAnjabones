using UnityEngine;

public class respawn : MonoBehaviour
{
    public Transform checkpoint1;
    Rigidbody2D miRB;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Cambio la posicion del objeto a 0,0 al iniciar el programa
        //transform.position=new Vector2(0,0);
        miRB=GetComponent<Rigidbody2D>();//Obtenemos el componente RB de nuestra pelota
    }

    // Update is called once per frame
    void Update()
    {
        //Si la pelota cae a menos de -10, regresamos al checkpoint1
        if(transform.position.y<-10)
        {
            transform.position=checkpoint1.position;
            miRB.linearVelocity=Vector2.zero;//reseteamos la velocidad a 0
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("enemigo"))
        {
            transform.position=checkpoint1.position;
            miRB.linearVelocity=Vector2.zero;//reseteamos la velocidad a 0
        }
    }


}
