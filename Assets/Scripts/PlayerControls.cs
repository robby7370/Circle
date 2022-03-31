using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    private Rigidbody2D rb2d;
    public KeyCode moveUp = KeyCode.W;
    public KeyCode moveDown = KeyCode.S;
    public KeyCode moveLeft = KeyCode.A;
    public KeyCode moveRight = KeyCode.D;
    
    public float speed = 10.0f;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();

        rb2d.AddForce(new Vector2(20, 15));
    }

    // Update is called once per frame
    void Update()
    {
        var vel = rb2d.velocity;
        if (Input.GetKey(moveUp)) {
            vel.y = speed;
        }
        else if (Input.GetKey(moveDown)) {
            vel.y = -speed;
        }
        else {
            vel.y = 0;
        }
        

        if (Input.GetKey(moveRight)) {
            vel.x = speed;
        }
        else if (Input.GetKey(moveLeft)) {
            vel.x = -speed;
        }
        else {
            vel.x = 0;
        }

        rb2d.velocity = vel;
        
    }
}
