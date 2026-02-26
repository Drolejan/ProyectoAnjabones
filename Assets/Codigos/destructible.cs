using UnityEngine;

public class destructible : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Respawn"))
        {
            Destroy(gameObject);
        }
    }
}
