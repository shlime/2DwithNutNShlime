using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {


	Camera cam;
	Vector3 currMousePos;
	Vector3 newpos;


	void Start()
	{
		cam = Camera.main;
	}

	void Update () {

		currMousePos = cam.ScreenToWorldPoint (Input.mousePosition);

		if(Input.GetKey(KeyCode.W))
			cam.transform.position = new Vector3 (cam.transform.position.x, cam.transform.position.y + 1f * 0.5f, 0);

		if(Input.GetKey(KeyCode.S))
			cam.transform.position = new Vector3 (cam.transform.position.x, cam.transform.position.y - 1f * 0.5f, 0);

		if(Input.GetKey(KeyCode.A))
			cam.transform.position = new Vector3 (cam.transform.position.x - 1f * 0.5f, cam.transform.position.y, 0);

		if(Input.GetKey(KeyCode.D))
			cam.transform.position = new Vector3 (cam.transform.position.x + 1f * 0.5f, cam.transform.position.y, 0);

		if (Input.GetMouseButton (2)) {

			Vector3 difference = newpos - currMousePos;
			cam.transform.Translate (difference);

		}

		newpos = cam.ScreenToWorldPoint (Input.mousePosition);

	}
}
