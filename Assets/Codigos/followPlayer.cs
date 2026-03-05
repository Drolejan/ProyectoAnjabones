using UnityEngine;

public class followPlayer : MonoBehaviour
{
    public Transform player;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Busco el objeto personaje y obtengo el componente transform
        player=GameObject.Find("PERSONAJE").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position=new Vector3(player.position.x,player.position.y,transform.position.z);
    }
}
