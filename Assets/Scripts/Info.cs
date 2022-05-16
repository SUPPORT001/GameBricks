using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Info : MonoBehaviour
{
    private GameObject live = null;
    private GameObject lives = null;
    private GameObject points = null;

    private void Awake()
    {
        live = GameObject.Find("true_Live").gameObject;
        lives = GameObject.Find("Lives").gameObject;
        points = GameObject.Find("Points").gameObject;
    }

    private void Start()
    {
        for (int i = 1; i <= Config.lives; i++)
        {
            GameObject go = Instantiate(live);
            go.transform.SetParent(lives.transform, false);
            go.transform.position = new Vector3(lives.transform.position.x, lives.transform.position.x * -0.1f * i, 1);
            go.name = "Live #" + i;
            Config.livesList.Add(go);
        }
    }
}
