using UnityEngine;
using System.Collections;

public class LightController : MonoBehaviour {

    public GameObject gameController;
    public Sprite onSprite;
    public Sprite offSprite;

    private SpriteRenderer renderer;
    private GameController controller;

	void Start () {
        renderer = GetComponent<SpriteRenderer>();
        controller = gameController.GetComponent<GameController>();
	}
	
	void Update () {
        renderer.sprite = (controller.isStopped) ? offSprite : onSprite;
	}

}
