using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

    public GameObject gameCamera;
    public bool isStopped = false;
    public Color stopColor;
    public Color startColor;

    private bool keyPushed = false;
    private Camera cameraComponent;

	void Start () {
        cameraComponent = gameCamera.GetComponent<Camera>();
	}
	
	void Update () {
        if (keyPushed && !Input.GetKey("space")) {
            keyPushed = false;
        } else if (!keyPushed && Input.GetKey("space")) {
            keyPushed = true;
            ButtonPressed();
        }
	}
    
    void ButtonPressed() {
        isStopped = !isStopped;
        cameraComponent.backgroundColor = (isStopped) ? stopColor : startColor;
    }

}
