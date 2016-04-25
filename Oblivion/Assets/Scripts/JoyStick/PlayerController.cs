﻿using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
	public VirtualJoystick_left jsL;
	public VirtualJoystick_right jsR;
	public float moveSpeed;
	public float terminalRotationSpeed = 25.0f;
	public Camera mainCamera;
	private Ray ray;
	private RaycastHit hit;

	private Vector3 MoveVector;
	private Rigidbody rb;
	// Use this for initialization

	void Start () {
		rb = gameObject.GetComponent<Rigidbody> ();
		rb.maxAngularVelocity = terminalRotationSpeed;
	}
	
	// Update is called once per frame
	void Update () {
		MoveVector = PoolRightInput ();
		Vector3 v = MoveVector * moveSpeed;
		rb.AddRelativeForce (v*20);
		float norm = rb.velocity.magnitude;
		if (rb.velocity.magnitude > 0.8f*norm)
			rb.velocity = rb.velocity.normalized * 0.8f * norm;
		if (MoveVector == Vector3.zero)
			rb.velocity = Vector3.zero;
		gameObject.transform.Rotate (new Vector3(0,jsR.Turn ()*1.3f,0));

		if(Input.GetMouseButtonDown(0)){
			ray = Camera.main.ScreenPointToRay(Input.mousePosition);

			if(Physics.Raycast(ray, out hit, Mathf.Infinity)){
				GameItems clickObj = hit.transform.gameObject.GetComponent<GameItems>();
				if (clickObj != null) {
					Debug.Log ("Click GameItems");
					clickObj.ClickInteraction ();
				} else {
					Debug.Log ("Click nothing");
				}
			}
		}
	}

	private Vector3 PoolRightInput(){
		Vector3 dir = Vector3.zero;
		dir.x = jsL.Horizontal ();
		dir.z = jsL.Vertical ();
		if (dir.magnitude > 1)
			dir.Normalize ();
		return dir;
	}
}
