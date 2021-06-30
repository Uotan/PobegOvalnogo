using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ForDrone : MonoBehaviour
{
    public Sprite Crash;
    public SpriteRenderer face;
    private Rigidbody2D body;
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
        face = GetComponent<SpriteRenderer>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            face.sprite = Crash;
        }
    }
    

}
