using UnityEngine;
using System.Collections;

public class CourgetteController : MonoBehaviour {

    public GameObject controllerObject;
    public float scrollSpeedX;
    public float scrollSpeedY;
    public float tileWidth;

    private GameController controller;
    private Vector3 startPosition;

    private float internalClockX;
    private float internalClockY;
    private float lastTick;

    private BoxCollider2D collider;

    private bool falling = false;

    void Start() {
        controller = controllerObject.GetComponent<GameController>();
        startPosition = transform.position;

        internalClockX = 0.0f;
        internalClockY = 0.0f;
        lastTick = Time.time;

        collider = GetComponent<BoxCollider2D>();
    }

    void Update() {
        if (falling) {
            if (!controller.isStopped) {
                internalClockX += Time.time - lastTick;
            }
            internalClockY += Time.time - lastTick;
            float newPositionX = internalClockX * scrollSpeedX;
            float newPositionY = internalClockY * scrollSpeedY;
            transform.position = startPosition + Vector3.left * newPositionX +
                Vector3.down * newPositionY;

            if (newPositionY > 25) {
                falling = false;
            }
        }
        lastTick = Time.time;
    }

    void FixedUpdate() {
        if (!falling && Random.value < 0.05) {
            falling = true;
            transform.position = startPosition;
            internalClockX = Random.value * 1.0f;
            internalClockY = 0.0f;
        }
    }

    void OnCollisionEnter(Collision collision) {
        controller.timer -= 20f;
    }

}
