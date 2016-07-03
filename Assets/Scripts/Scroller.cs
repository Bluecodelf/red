using UnityEngine;
using System.Collections;

public class Scroller : MonoBehaviour {

    public GameObject controllerObject;
	public float scrollSpeed;
	public float tileWidth;

    private GameController controller;
	private Vector3 startPosition;

    private float internalClock;
    private float lastTick;

	void Start () {
        controller = controllerObject.GetComponent<GameController>();
		startPosition = transform.position;

        internalClock = 0.0f;
        lastTick = Time.time;
	}
	
	void Update () {
        if (!controller.isStopped) {
            internalClock += Time.time - lastTick;
            float newPosition = Mathf.Repeat(internalClock * scrollSpeed, tileWidth);
            transform.position = startPosition + Vector3.left * newPosition;
        }
        lastTick = Time.time;
    }

}
