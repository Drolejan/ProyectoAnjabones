using UnityEngine;

public class enemigo : MonoBehaviour
{
    public Transform punto1,punto2;
    Transform objetivo;
    public float velocidad;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        objetivo=punto1;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position=Vector2.MoveTowards(transform.position,objetivo.position,velocidad*Time.deltaTime);

        if (Vector2.Distance(transform.position, objetivo.position) < 0.5f)
        {
            if (objetivo == punto1)
            {
                objetivo=punto2;
            }
            else if (objetivo == punto2)
            {
                objetivo=punto1;
            }
        }
    }
}
