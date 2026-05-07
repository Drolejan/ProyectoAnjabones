using UnityEngine;

public class movimientoAlien : MonoBehaviour
{
    public float speed;
    void Start()
    {
        
    }
    void Update()
    {
        transform.position+=Vector3.right*Time.deltaTime*speed;
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        speed*=-1;
        transform.position=new Vector3(transform.position.x,transform.position.y-1,transform.position.z);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        gameObject.SetActive(false);
        speed=0;
        transform.position=Vector3.zero;
    }
}
