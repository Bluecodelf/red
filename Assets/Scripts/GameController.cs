using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

    public GameObject gameCamera;
    public GameObject playerObject;
    public bool isStopped = false;
    public Color stopColor;
    public Color startColor;

    private bool keyPushed = false;
    private Camera cameraComponent;
    private Animator animatorComponent;

	void Start () {
        cameraComponent = gameCamera.GetComponent<Camera>();
        animatorComponent = playerObject.GetComponent<Animator>();
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
        animatorComponent.SetInteger("run", (isStopped) ? 1 : 0);
        cameraComponent.backgroundColor = (isStopped) ? stopColor : startColor;
    }

}
