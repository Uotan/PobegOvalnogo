using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeletePrefs : MonoBehaviour
{
    public Sprite [] onoff = new Sprite [2] ;
    SpriteRenderer Face;
    private void Start()
    {
        Face = GetComponent<SpriteRenderer>();
    }
    private void OnMouseUp()
    {
        Face.sprite = onoff[0];
        OopClass.BestScore = 0f;
        PlayerPrefs.DeleteKey("score");
    }
    private void OnMouseDown()
    {
        Face.sprite = onoff[1];
    }
}
