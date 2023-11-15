using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Baller : MonoBehaviour
{
    public float moveForce = 1;
    Rigidbody2D rb;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        var hor = Input.GetAxis("Horizontal");
        rb.AddForce(new Vector2(hor * moveForce, 0));
        if (Input.GetButtonDown("Jump"))
        {
            Jump();
        }
    }

    void Jump()
    {
        rb.velocity = Vector2.up * 5;
    }




}
