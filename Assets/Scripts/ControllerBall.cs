using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerBall : MonoBehaviour
{
    private Vector3 mousepos = Vector3.zero;

    private bool f;

    private void Start()
    {
        f = false;
    }

    private void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            mousepos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mousepos.z = 0;
            mousepos.x = mousepos.x - this.transform.position.x;
            mousepos.y = mousepos.y - this.transform.position.y;
            if (!Config.startGame)
            {
                Debug.Log("Старт игры!");
                Config.startGame = true;
                this.GetComponent<Rigidbody2D>().velocity = mousepos.normalized * Config.speedBall;
            }
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (Config.startGame)
        {
            if(!f)
            {
                Vector2 pos = this.GetComponent<Rigidbody2D>().velocity;
                if (collision.name == "Right" || collision.name == "Left")
                {
                    pos.x *= -1;
                }
                else if (collision.name == "Top" || collision.name == "Platforma")
                {
                    pos.y *= -1;
                }
                else if (collision.name == "Bottom")
                {
                    dead();
                    this.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
                    this.transform.position = new Vector3(GameObject.Find("Platforma").transform.position.x, Config.startBallY, 0); ;
                    Config.startGame = false;
                    return;
                }
                this.GetComponent<Rigidbody2D>().velocity = pos;
                f = true;
            }
        }
        //print("Контакт с объектом");
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        f = false;
    }

    private void dead()
    {
        if(Config.lives > 1)
        {
            Config.lives--;
            foreach (GameObject item in Config.livesList)
            {
                Config.livesList.Remove(item);
                Destroy(item);
                break;
            }
        }
        else
        {
            Config.lives--;
            foreach (GameObject item in Config.livesList)
            {
                Config.livesList.Remove(item);
                Destroy(item);
                break;
            }
            Debug.Log("Конец игры.");
            this.gameObject.SetActive(false);
        }
    }
}
