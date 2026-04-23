using UnityEngine;

public class instrument : MonoBehaviour
{
    public KeyCode tecla;
    SpriteRenderer colorTecla;
    Collider2D colTecla;
    public AudioClip teclaSound;
    void Start()
    {
        colorTecla=GetComponent<SpriteRenderer>();
        colTecla=GetComponent<Collider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(tecla))
        {
            colTecla.enabled=true;
            colorTecla.color=Color.red;
        }

        if (Input.GetKeyUp(tecla))
        {
            colTecla.enabled=false;
            colorTecla.color=Color.white;
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(collision.gameObject);
        AudioSource au= new AudioSource();
        AudioSource.PlayClipAtPoint(teclaSound,transform.position);
    }
}
