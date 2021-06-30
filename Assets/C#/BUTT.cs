using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BUTT : MonoBehaviour
{
    public Sprite[] onoff = new Sprite[2];
    SpriteRenderer Face;
    private void Start()
    {
        Face = GetComponent<SpriteRenderer>();
    }
    private void OnMouseUp()
    {
        Face.sprite = onoff[0];
        PlayerPrefs.SetString("firstrun?","true"); //нужна, чтобы при первом забеге показывалась подсказка управления
        SceneManager.LoadScene(1);
    }
    private void OnMouseDown()
    {
        Face.sprite = onoff[1];
    }
    private void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
    

}
