using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour {

	public GameObject player;
	private float cameraOffset;
	// Use this for initialization
	void Awake() {
		cameraOffset = transform.position.x - player.transform.position.x;
	}
	
	// Update is called once per frame
	void Update () {

	transform.position = new Vector3 (player.transform.position.x + cameraOffset, transform.position.y, -10);
		
	}
}
