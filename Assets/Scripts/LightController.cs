using UnityEngine;
using System.Collections;

public class LightController : MonoBehaviour {

    public GameObject gameController;
    public Sprite onSprite;
    public Sprite offSprite;

    private SpriteRenderer spriteRenderer;
    private GameController controller;

	void Start () {
        spriteRenderer = GetComponent<SpriteRenderer>();
        controller = gameController.GetComponent<GameController>();
	}
	
	void Update () {
        spriteRenderer.sprite = (controller.isStopped) ? offSprite : onSprite;
	}

}
