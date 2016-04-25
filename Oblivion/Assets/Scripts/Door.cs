using UnityEngine;
using System.Collections;

public class Door : GameItems {
	public float speed;
	public GameObject axis;

	private Ray ray;
	private RaycastHit hit;
	private float openFlag;

	// Use this for initialization
	void Start () {
		openFlag = 1.0f;
	}
	
	// Update is called once per frame
	public override void ClickInteraction() {
		axis.transform.Rotate (new Vector3 (0, 70.0f * openFlag, 0));
		openFlag = - openFlag;
	}
}