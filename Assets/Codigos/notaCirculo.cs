using UnityEngine;

public class notaCirculo : MonoBehaviour
{
    public AudioClip sonidoNota;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        AudioSource.PlayClipAtPoint(sonidoNota,transform.position);
    }
}
