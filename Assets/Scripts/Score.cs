using UnityEngine;
using System.Collections;

public class Score : MonoBehaviour {

    private int timer;
    private int distance;
    private GUIText display;
    public GameController gameController;

	// Use this for initialization
	void Start () 
    {
        display = GetComponent<GUIText>();
	}
	
	// Update is called once per frame
	void Update () 
    {
        timer = gameController.timer;
        distance = gameController.distance;
        display = "Time left: " + timer + "\n Distance: " + distance;

        timer -= Time.deltaTime;
	}
}
