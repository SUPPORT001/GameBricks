using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateBricks : MonoBehaviour
{
    private GameObject brick = null;
    private List<GameObject> bricks = new List<GameObject>();
    private GameObject pole = null;

    private void Awake()
    {
        brick = GameObject.Find("true_Brick");
        pole = GameObject.Find("Pole");
    }

    private void Start()
    {
        for (int XX = 0; XX < 34; XX++)
        {
            for (int YY = 0; YY < 30; YY++)
            {
                GameObject go = Instantiate(brick);
                go.transform.SetParent(pole.transform);

            }
        }
    }
}
