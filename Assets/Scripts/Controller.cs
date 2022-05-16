using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    private GameObject platforma = null;
    private Vector3 mousepos = Vector3.zero;

    private void Awake()
    {
        platforma = this.gameObject;
    }

    private void Update()
    {
        mousepos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }

    private void FixedUpdate()
    {
        if (Config.startGame)
        {
            mousepos.y = this.transform.position.y;
            mousepos.z = 0;

            if (mousepos.x > this.transform.position.x)
            {
                if (!Config.closeRight)
                {
                    platforma.transform.position = Vector3.MoveTowards(this.transform.position, mousepos, Time.deltaTime * Config.speedPlatform);
                }
            }
            else
            {
                if (!Config.closeLeft)
                {
                    platforma.transform.position = Vector3.MoveTowards(this.transform.position, mousepos, Time.deltaTime * Config.speedPlatform);
                }
            }
        }
    }
}
