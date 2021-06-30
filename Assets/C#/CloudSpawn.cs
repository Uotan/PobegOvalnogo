using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudSpawn : MonoBehaviour
{
    public GameObject g0;
    public GameObject g1;
    public GameObject g2;
    public GameObject g3;
    public GameObject g4;
    public GameObject g5;
    public GameObject g6;
    int R;
    int M;

    float WaitSec = 2f;
    public ForText script2;
    void Start()
    {
        //script2 = GameObject.Find("Text").GetComponent<ForText>();
        StartCoroutine(Corut());
    }
    IEnumerator Corut()
    {
        while (true)
        {
            yield return new WaitForSeconds(WaitSec);
            M = Random.Range(1, 4);
            if (M == 1)
            {
                R = Random.Range(1, 7);
                switch (R)
                {
                    case 1: Instantiate(g1, new Vector2(g0.transform.position.x, 1.939f+0.2f), Quaternion.identity); break;
                    case 2: Instantiate(g2, new Vector2(g0.transform.position.x, 1.939f+0.2f), Quaternion.identity); break;
                    case 3: Instantiate(g3, new Vector2(g0.transform.position.x, 1.939f+0.2f), Quaternion.identity); break;
                    case 4: Instantiate(g4, new Vector2(g0.transform.position.x, 1.939f+0.2f), Quaternion.identity); break;
                    case 5: Instantiate(g5, new Vector2(g0.transform.position.x, 1.939f+0.2f), Quaternion.identity); break;
                    case 6: Instantiate(g6, new Vector2(g0.transform.position.x, 1.939f+0.2f), Quaternion.identity); break;
                    default:
                        break;
                }
            }
            if (M == 2)
            {
                R = Random.Range(1, 7);
                switch (R)
                {
                    case 1: Instantiate(g1, new Vector2(g0.transform.position.x, 1.003f+0.2f), Quaternion.identity); break;
                    case 2: Instantiate(g2, new Vector2(g0.transform.position.x, 1.003f+0.2f), Quaternion.identity); break;
                    case 3: Instantiate(g3, new Vector2(g0.transform.position.x, 1.003f+0.2f), Quaternion.identity); break;
                    case 4: Instantiate(g4, new Vector2(g0.transform.position.x, 1.003f+0.2f), Quaternion.identity); break;
                    case 5: Instantiate(g5, new Vector2(g0.transform.position.x, 1.003f+0.2f), Quaternion.identity); break;
                    case 6: Instantiate(g6, new Vector2(g0.transform.position.x, 1.003f+0.2f), Quaternion.identity); break;
                    default:
                        break;
                }
            }
            if (M == 3)
            {
                R = Random.Range(1, 7);
                switch (R)
                {
                    case 1: Instantiate(g1, new Vector2(g0.transform.position.x, 2.162f+0.2f), Quaternion.identity); break;
                    case 2: Instantiate(g2, new Vector2(g0.transform.position.x, 2.162f+0.2f), Quaternion.identity); break;
                    case 3: Instantiate(g3, new Vector2(g0.transform.position.x, 2.162f+0.2f), Quaternion.identity); break;
                    case 4: Instantiate(g4, new Vector2(g0.transform.position.x, 2.162f+0.2f), Quaternion.identity); break;
                    case 5: Instantiate(g5, new Vector2(g0.transform.position.x, 2.162f+0.2f), Quaternion.identity); break;
                    case 6: Instantiate(g6, new Vector2(g0.transform.position.x, 2.162f+0.2f), Quaternion.identity); break;
                    default:
                        break;
                }
            }
            WaitSec = Random.Range(1, 4);

        }
    }
}
