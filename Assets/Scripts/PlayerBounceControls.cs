using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBounceControls : MonoBehaviour
{
    private Rigidbody2D rb2d;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();

        rb2d.AddForce(new Vector2(20, 10));
    }


}
