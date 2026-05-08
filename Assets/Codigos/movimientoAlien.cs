using UnityEngine;

public class movimientoAlien : MonoBehaviour
{
    

    void OnCollisionEnter2D(Collision2D collision)
    {
        gameObject.SetActive(false);
        Destroy(collision.gameObject);//Destruye la bala
    }
}
