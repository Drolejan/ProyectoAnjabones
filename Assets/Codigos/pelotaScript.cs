using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class pelotaScript : MonoBehaviour
{
    PlayerInput controles;
    Rigidbody2D rbPelota;
    public TextMeshProUGUI textop1,textop2;
    int scorep1,scorep2;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        controles=GetComponent<PlayerInput>();
        rbPelota=GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (controles.actions["Attack"].WasPressedThisFrame())
        {
            rbPelota.AddForce(new Vector2(1,1)*10,ForceMode2D.Impulse);
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("porteriap1"))
        {
            scorep2++;
            textop2.text="Player 2: " + scorep2.ToString();
            resetBall();
        }
        else if (collision.gameObject.CompareTag("porteriap2"))
        {
            scorep1++;
            textop1.text="Player 1: " + scorep1.ToString();
            resetBall();
        }
    }

    void resetBall()
    {
        transform.position=Vector2.zero;
        rbPelota.linearVelocity=Vector2.zero;
    }
}
