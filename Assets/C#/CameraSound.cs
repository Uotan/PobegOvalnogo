using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSound : MonoBehaviour
{
    public AudioSource AL;
    private void Start()
    {
        AL = GetComponent<AudioSource>();
    }
    void Update()
    {
        if (PlayerPrefs.GetInt("sound")==1)
        {
            AL.volume = 0.5f;
        }
        else
        {
            AL.volume = 0f;
        }
    }
}
