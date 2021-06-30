using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForCloud : MonoBehaviour
{
    public Rigidbody2D body;
    public ForText script;
    private float ES;
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
        script = GameObject.Find("Text").GetComponent<ForText>();
    }

    void Update()
    {
        ES = script.speed/4;
        body.velocity = new Vector2(ES * 50 * Time.fixedDeltaTime, body.velocity.y);
    }
}
