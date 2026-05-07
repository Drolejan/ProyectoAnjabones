using UnityEngine;

public class movimientoBarraSound : MonoBehaviour
{
    public float speed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position+=Vector3.right*Time.deltaTime*speed;
        if (transform.position.x > 9.5f)
        {
            transform.position=new Vector3(-9.5f,transform.position.y,transform.position.z);
        }
    }
}
