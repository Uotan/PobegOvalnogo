using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudMove : MonoBehaviour
{
    public Rigidbody2D body;
    private float ES = -1.5f;
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        body.velocity = new Vector2(ES * 50 * Time.fixedDeltaTime, body.velocity.y);
    }
}
