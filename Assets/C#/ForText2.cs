using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ForText2 : MonoBehaviour
{
    public Text string1;
    void Update()
    {
        string1.text = "HI " + OopClass.BestScore.ToString();
    }
}
