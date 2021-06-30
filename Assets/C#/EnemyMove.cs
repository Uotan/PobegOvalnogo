using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    Rigidbody2D body;
    public ForText script;
    private float ES;

    void Start()
    {
        body = GetComponent<Rigidbody2D>();
        script = GameObject.Find("Text").GetComponent<ForText>();
        ES = script.speed;
    }

    private void FixedUpdate()
    {
        //body.velocity = new Vector2(ES, body.velocity.y);       
        body.velocity = new Vector2(ES * 50 * Time.fixedDeltaTime, body.velocity.y);
    }
    
    
}
