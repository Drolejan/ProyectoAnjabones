using UnityEngine;

public class moveRight : MonoBehaviour
{
    Rigidbody2D pRb;
    public float vel;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        pRb=GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        pRb.linearVelocityX=vel;
    }
}
