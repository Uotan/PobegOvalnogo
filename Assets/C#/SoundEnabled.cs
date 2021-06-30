using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundEnabled : MonoBehaviour
{
    public int allsound;
    public bool onoff= true;
    public SpriteRenderer PIC;
    public Sprite [] sprites = new Sprite [2];
    private void Start()
    {
        PIC = GetComponent<SpriteRenderer>();
        if (PlayerPrefs.HasKey("sound") == false)
        {
            PlayerPrefs.SetInt("sound", 1);
            allsound = PlayerPrefs.GetInt("sound");
        }
        else
        {
            allsound = PlayerPrefs.GetInt("sound");
        }
        if (allsound == 1)
        {
            onoff = true;
        }
        if (allsound == 0)
        {
            onoff = false;
        }
    }
    private void Update()
    {
        if (onoff == true)
        {
            PIC.sprite = sprites[0];
        }
        if (onoff == false)
        {
            PIC.sprite = sprites[1];
        }
    }
    private void OnMouseUp()
    {
        onoff = !onoff;
        if (onoff == true)
        {
            allsound = 1;
            PlayerPrefs.SetInt("sound", allsound);
        }
        if (onoff == false)
        {
            allsound = 0;
            PlayerPrefs.SetInt("sound", allsound);
        }
    }
}
