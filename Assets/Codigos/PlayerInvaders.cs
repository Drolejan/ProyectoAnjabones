using Unity.Mathematics;
using UnityEngine;

public class PlayerInvaders : MonoBehaviour
{
    public GameObject balaInvaders;
    public float speedBala;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            GameObject laBala=Instantiate(balaInvaders,transform.position,Quaternion.identity);
            laBala.GetComponent<Rigidbody2D>().AddForceY(speedBala,ForceMode2D.Impulse);
        }
    }
}
