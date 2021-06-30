using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu1 : MonoBehaviour
{
    public Camera You;
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
        You.transform.position = new Vector3(0f, 0f, -10f);
    }
}
