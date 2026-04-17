using UnityEngine;
using UnityEngine.InputSystem;

public class controlPlayer : MonoBehaviour
{
    public PlayerInput controlp1;
    Rigidbody2D rbPlayer;
    public float playerSpeed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rbPlayer=GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float movP1= controlp1.actions["Move"].ReadValue<Vector2>().y;

        rbPlayer.linearVelocityY=movP1*playerSpeed;
    }
}
