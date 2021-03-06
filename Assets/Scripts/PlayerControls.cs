using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerWASDControls : MonoBehaviour
{
    private Rigidbody2D rb2d;
    public KeyCode moveUp = KeyCode.W;
    public KeyCode moveDown = KeyCode.S;
    public KeyCode moveLeft = KeyCode.A;
    public KeyCode moveRight = KeyCode.D;
    
    public float speed = 10.0f;

    Vector2 target;


    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();

        target = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
        onKeyMove();

        //onClickMove();
        
    }


    private void onClickMove()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0)) 
        {
            if (Input.GetMouseButtonDown(0)) 
            {
                 //Debug.Log(Camera.main.ScreenToWorldPoint(Input.mousePosition));
                 //Vector3 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                 
                //direction = (Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position);
                target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                
                //rb2d.AddForce(direction * speed);
            }
            
        }
        transform.position = Vector2.MoveTowards(transform.position, target, speed * Time.deltaTime);
    }

    private void onKeyMove()
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
