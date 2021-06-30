using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject g0;
    public GameObject g1;
    public GameObject g2;
    public GameObject g3;
    public GameObject g4;
    public GameObject g5;
    public GameObject g6;
    public GameObject g7;
    public GameObject g8;
    public GameObject g9;
    public GameObject g10;
    public GameObject g11;
    //public GameObject g5;
    int R;
    int M;
    public ForText script2;
    void Start()
    {
        script2 = GameObject.Find("Text").GetComponent<ForText>();
        StartCoroutine(Corut());
    }
    IEnumerator Corut()
    {
        while (true)
        {
            yield return new WaitForSeconds(script2.SpawnSpeed);

            M = Random.Range(1,4);
            if (M==1)
            {
                R = Random.Range(1, 18);
                switch (R)
                {
                    case 1: Instantiate(g1, new Vector2(g0.transform.position.x, g0.transform.position.y), Quaternion.identity); break;
                    case 2: Instantiate(g2, new Vector2(g0.transform.position.x, g0.transform.position.y), Quaternion.identity); break;
                    case 3: Instantiate(g2, new Vector2(g0.transform.position.x, g0.transform.position.y), Quaternion.identity); break;
                    case 4: Instantiate(g10, new Vector2(g0.transform.position.x, g0.transform.position.y), Quaternion.identity); break;
                    case 5: Instantiate(g10, new Vector2(g0.transform.position.x, g0.transform.position.y), Quaternion.identity); break;
                    case 6: Instantiate(g3, new Vector2(g0.transform.position.x, g0.transform.position.y), Quaternion.identity); break;
                    case 7: Instantiate(g4, new Vector2(g0.transform.position.x, g0.transform.position.y), Quaternion.identity); break;
                    case 8: Instantiate(g5, new Vector2(g0.transform.position.x, g0.transform.position.y), Quaternion.identity); break;
                    case 9: Instantiate(g6, new Vector2(g0.transform.position.x, g0.transform.position.y), Quaternion.identity); break;
                    case 10: Instantiate(g7, new Vector2(g0.transform.position.x, g0.transform.position.y), Quaternion.identity); break;
                    case 11: Instantiate(g8, new Vector2(g0.transform.position.x, g0.transform.position.y), Quaternion.identity); break;
                    case 12: Instantiate(g9, new Vector2(g0.transform.position.x, g0.transform.position.y), Quaternion.identity); break;
                    case 13: Instantiate(g11, new Vector2(g0.transform.position.x, -0.731f), Quaternion.identity); break;
                    case 14: Instantiate(g11, new Vector2(g0.transform.position.x, -0.731f), Quaternion.identity); break;
                    case 15: Instantiate(g11, new Vector2(g0.transform.position.x, -0.731f), Quaternion.identity); break;
                    case 16: Instantiate(g11, new Vector2(g0.transform.position.x, -0.731f), Quaternion.identity); break;
                    case 17: Instantiate(g11, new Vector2(g0.transform.position.x, -0.731f), Quaternion.identity); break;
                    default:
                        break;
                }
            }
            if (M==2)
            {
                R = Random.Range(1, 18);
                switch (R)
                {
                    case 1: Instantiate(g1, new Vector2(g0.transform.position.x+3f, g0.transform.position.y), Quaternion.identity); break;
                    case 2: Instantiate(g2, new Vector2(g0.transform.position.x+3f, g0.transform.position.y), Quaternion.identity); break;
                    case 3: Instantiate(g2, new Vector2(g0.transform.position.x+3f, g0.transform.position.y), Quaternion.identity); break;
                    case 4: Instantiate(g10, new Vector2(g0.transform.position.x+3f, g0.transform.position.y), Quaternion.identity); break;
                    case 5: Instantiate(g10, new Vector2(g0.transform.position.x+3f, g0.transform.position.y), Quaternion.identity); break;
                    case 6: Instantiate(g3, new Vector2(g0.transform.position.x+3f, g0.transform.position.y), Quaternion.identity); break;
                    case 7: Instantiate(g4, new Vector2(g0.transform.position.x+3f, g0.transform.position.y), Quaternion.identity); break;
                    case 8: Instantiate(g5, new Vector2(g0.transform.position.x+3f, g0.transform.position.y), Quaternion.identity); break;
                    case 9: Instantiate(g6, new Vector2(g0.transform.position.x+3f, g0.transform.position.y), Quaternion.identity); break;
                    case 10: Instantiate(g7, new Vector2(g0.transform.position.x+3f, g0.transform.position.y), Quaternion.identity); break;
                    case 11: Instantiate(g8, new Vector2(g0.transform.position.x+3f, g0.transform.position.y), Quaternion.identity); break;
                    case 12: Instantiate(g9, new Vector2(g0.transform.position.x+3f, g0.transform.position.y), Quaternion.identity); break;
                    case 13: Instantiate(g11, new Vector2(g0.transform.position.x + 3f, -0.731f), Quaternion.identity); break;
                    case 14: Instantiate(g11, new Vector2(g0.transform.position.x+3f, -0.731f), Quaternion.identity); break;
                    case 15: Instantiate(g11, new Vector2(g0.transform.position.x+3f, -0.731f), Quaternion.identity); break;
                    case 16: Instantiate(g11, new Vector2(g0.transform.position.x+3f, -0.731f), Quaternion.identity); break;
                    case 17: Instantiate(g11, new Vector2(g0.transform.position.x+3f, -0.731f), Quaternion.identity); break;
                    default:
                        break;
                }
            }
            if (M==3)
            {
                R = Random.Range(1, 18);
                switch (R)
                {
                    case 1: Instantiate(g1, new Vector2(g0.transform.position.x + 5f, g0.transform.position.y), Quaternion.identity); break;
                    case 2: Instantiate(g2, new Vector2(g0.transform.position.x + 5f, g0.transform.position.y), Quaternion.identity); break;
                    case 3: Instantiate(g2, new Vector2(g0.transform.position.x + 5f, g0.transform.position.y), Quaternion.identity); break;
                    case 4: Instantiate(g10, new Vector2(g0.transform.position.x + 5f, g0.transform.position.y), Quaternion.identity); break;
                    case 5: Instantiate(g10, new Vector2(g0.transform.position.x + 5f, g0.transform.position.y), Quaternion.identity); break;
                    case 6: Instantiate(g3, new Vector2(g0.transform.position.x + 5f, g0.transform.position.y), Quaternion.identity); break;
                    case 7: Instantiate(g4, new Vector2(g0.transform.position.x + 5f, g0.transform.position.y), Quaternion.identity); break;
                    case 8: Instantiate(g5, new Vector2(g0.transform.position.x + 5f, g0.transform.position.y), Quaternion.identity); break;
                    case 9: Instantiate(g6, new Vector2(g0.transform.position.x + 5f, g0.transform.position.y), Quaternion.identity); break;
                    case 10: Instantiate(g7, new Vector2(g0.transform.position.x + 5f, g0.transform.position.y), Quaternion.identity); break;
                    case 11: Instantiate(g8, new Vector2(g0.transform.position.x + 5f, g0.transform.position.y), Quaternion.identity); break;
                    case 12: Instantiate(g9, new Vector2(g0.transform.position.x + 5f, g0.transform.position.y), Quaternion.identity); break;
                    case 13: Instantiate(g11, new Vector2(g0.transform.position.x + 5f, -0.731f), Quaternion.identity); break;
                    case 14: Instantiate(g11, new Vector2(g0.transform.position.x + 5f, -0.731f), Quaternion.identity); break;
                    case 15: Instantiate(g11, new Vector2(g0.transform.position.x + 5f, -0.731f), Quaternion.identity); break;
                    case 16: Instantiate(g11, new Vector2(g0.transform.position.x + 5f, -0.731f), Quaternion.identity); break;
                    case 17: Instantiate(g11, new Vector2(g0.transform.position.x + 5f, -0.731f), Quaternion.identity); break;
                    default:
                        break;
                }
            }
           
        }
    }
}
