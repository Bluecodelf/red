using UnityEngine;
using System.Collections;

public class Score : MonoBehaviour {

    public GameObject gameController;

    private int timer;
    private int distance;
    private GUIText display;
    private GameController controller;
    private string text;

	void Start () {
        display = GetComponent<GUIText>();
        controller = gameController.GetComponent<GameController>();
	}
	
	void Update () {
        timer = 180-(int) controller.timer;
        distance = (int) (controller.distanceTimer * 4.0f); // 4 meters/second
        text = "Time left: " + timer + "\nDistance: " + distance;

        if (timer <= 0)
        {
            text = "GAME OVER!\nDistance: " + distance;
        }

        display.text = text;
	}

}
