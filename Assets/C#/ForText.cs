using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ForText : MonoBehaviour
{
    public float timeMain;
    public Text textSTR;
    [Header("SPEEDS")]
    public float speed;
    public float SpawnSpeed;
    public bool Dead = true;

    public GameObject Player;
    Rigidbody2D PBody;

    private void Start()
    {
        PBody = Player.GetComponent<Rigidbody2D>();
        if (PlayerPrefs.HasKey("score"))
        {
            OopClass.BestScore = PlayerPrefs.GetFloat("score");
        }
    }

    void Update()
    {
        if (Dead == true)
        {
            timeMain += (Time.deltaTime * 2);
            textSTR.text = Mathf.Round(timeMain).ToString();
            if (timeMain>OopClass.BestScore)
            {
                
                OopClass.BestScore = Mathf.Round(timeMain);
                PlayerPrefs.SetFloat("score", OopClass.BestScore);
            }
            if (timeMain < 10)
            {
                speed = -12f;
                SpawnSpeed = 2f;
                PBody.gravityScale = 2.1f;
            }
            if (timeMain > 10 && timeMain<50)
            {
                speed = -12f;
                SpawnSpeed = 2.6f;
                PBody.gravityScale = 2.1f;
            }
            if (timeMain > 50f && timeMain < 100f)
            {
                speed = -12f;
                SpawnSpeed = 2.6f;
                PBody.gravityScale = 2.1f;
            }
            if (timeMain > 100f && timeMain < 150f)
            {
                speed = -14f;
                SpawnSpeed = 2.2f;
                PBody.gravityScale = 2.2f;
            }
            if (timeMain > 150f && timeMain < 200f)
            {
                speed = -16f;
                SpawnSpeed = 1.8f;
                PBody.gravityScale = 2.3f;
            }
            if (timeMain > 200f && timeMain < 250f)
            {
                speed = -18f;
                SpawnSpeed = 1.4f;
                PBody.gravityScale = 2.4f;
            }
            if (timeMain > 250f && timeMain<300f)
            {
                speed = -20f;
                SpawnSpeed = 1.35f;
                PBody.gravityScale = 2.45f;
            }
            if (timeMain > 300f)
            {
                speed = -20.6f;
                SpawnSpeed = 1.2f;
                PBody.gravityScale = 2.55f;
            }
        }
    }
}
