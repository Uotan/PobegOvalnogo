using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu2 : MonoBehaviour
{
    public Sprite[] onoff = new Sprite[2];
    SpriteRenderer Face;
    private void Start()
    {
        Face = GetComponent<SpriteRenderer>();
    }
    private void OnMouseDown()
    {
        Face.sprite = onoff[1];
    }
    private void OnMouseUp()
    {
        Face.sprite = onoff[0];
        SceneManager.LoadScene(0);
    }
    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            SceneManager.LoadScene(0);
        }
    }
}
