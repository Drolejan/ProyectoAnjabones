using UnityEngine;

public class disparar : MonoBehaviour
{
    public Rigidbody2D personajeRB;
    public float velocidad;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
          velocidad=Random.Range(15,30);  
          personajeRB.AddForce(Vector2.right*velocidad,ForceMode2D.Impulse);  
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Respawn"))
        {
            transform.position=Vector2.zero;
            personajeRB.linearVelocity=Vector2.zero;
            personajeRB.angularVelocity=0;
        }
    }
}
