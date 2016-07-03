using UnityEngine;
using System.Collections;

public class Score : MonoBehaviour {

    public GameObject gameController;

    private int timer;
    private int distance;
    private GUIText display;
    private GameController controller;

	void Start () {
        display = GetComponent<GUIText>();
        controller = gameController.GetComponent<GameController>();
	}
	
	void Update () {
        timer = 180-(int) controller.timer;
        distance = (int) (controller.distanceTimer * 4.0f); // 4 meters/second
        display.text = "Time left: " + timer + "\nDistance: " + distance;
	}

}
