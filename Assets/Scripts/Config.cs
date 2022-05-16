using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Config : object
{
    public static float speedPlatform = 4f;
    public static float speedBall = 5f;
    public static int lives = 3;
    public static List<GameObject> livesList = new List<GameObject>();
    public static int points = 0;

    public static float startBallY = -3.24f;

    public static bool closeRight = false;
    public static bool closeLeft = false;

    public static Vector3 top_left = new Vector3(-3.85f, 4.1f, 0);

    public static bool startGame = false;
}
