using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerBorder : MonoBehaviour
{

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (this.gameObject.name == "Right")
        {
            Config.closeRight = true;
        }
        else
        {
            Config.closeLeft = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (this.gameObject.name == "Right")
        {
            Config.closeRight = false;
        }
        else
        {
            Config.closeLeft = false;
        }
    }
}
