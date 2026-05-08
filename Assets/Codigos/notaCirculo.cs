using UnityEngine;

public class notaCirculo : MonoBehaviour
{
    public AudioClip sonidoNota;
    public AudioSource au;
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
        au.pitch = Random.Range(0.25f, 1.25f);//Desactivarlo si no quieres pitch al azar
        au.PlayOneShot(sonidoNota);
    }
}
