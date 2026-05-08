using UnityEngine;

public class magoMovimientos : MonoBehaviour
{
    Animator animPersonaje;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        animPersonaje=GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            animPersonaje.SetTrigger("jump");
        }
    }
}
