using UnityEngine;

public class movimientoEnjambre : MonoBehaviour
{
    public float speed;
    public bool resetGame;
    public movimientoAlien[] hordas;
    void Start()
    {
        hordas=gameObject.GetComponentsInChildren<movimientoAlien>();
    }
    void Update()
    {
        transform.position+=Vector3.right*Time.deltaTime*speed;
        if (resetGame)
        {
            transform.position=new Vector3(-5,3,0);
            foreach(movimientoAlien alien in hordas)
            {
                alien.gameObject.SetActive(true);
            }
        }
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("PARED")){
        speed*=-1;
        transform.position=new Vector3(transform.position.x,transform.position.y-1,transform.position.z); 
        }
        
    }
}
