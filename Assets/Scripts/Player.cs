using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	private Rigidbody2D rb;
	private SpriteRenderer spriteRenderer;
	public float speed;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D>();
		spriteRenderer = GetComponent<SpriteRenderer>();
		rb.gravityScale = speed;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		transform.Translate(.05f,0,0);

		if (Input.GetMouseButtonDown (0)) {
			rb.gravityScale *= -1f;
			if (rb.gravityScale < 0) {
				spriteRenderer.flipY = true;
			} else
			spriteRenderer.flipY = false;

		}
	}

}
