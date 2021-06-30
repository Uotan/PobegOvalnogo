using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class forHint : MonoBehaviour
{
    SpriteRenderer _sprtrender;
    float _a = 1f;
    void Start()
    {

        _sprtrender = GetComponent<SpriteRenderer>();
        if (PlayerPrefs.GetString("firstrun?")!="true") //собственно проверка - первый забег, или уже проигрывал
        {
            _sprtrender.color = new Color(0f,0f,0f,0f);
        }
    }
    private void FixedUpdate() {
        if (PlayerPrefs.GetString("firstrun?")=="true")
        {
             _sprtrender.color = new Color(1f,1f,1f,_a);
            _a-=0.003f;
        }
        if (_a<=0)
        {
            Destroy(this.gameObject);
        }
       
    }
}
