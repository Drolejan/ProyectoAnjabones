using UnityEngine;

public class controlCPU : MonoBehaviour
{
    public Transform posPelota;
    public float cpuSpeed;
    void Update()
    {
        Vector2 target= new Vector2(transform.position.x,posPelota.position.y);
        transform.position=Vector2.MoveTowards(transform.position,target,cpuSpeed*Time.deltaTime);
    }
}
