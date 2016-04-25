using UnityEngine;
using System.Collections;

public class SwitchController : GameItems {
	public GameObject switchAxis;
	private float angleOn = (float)(-25);
	private float angleOff = (float)(+25);
	private int state = 0;
	public override void ClickInteraction() {
		Debug.Log ("CLICK!");
		state = 1 - state;
		if (state==1) switchAxis.transform.Rotate (new Vector3 (0, 0, angleOn));
		if (state==0) switchAxis.transform.Rotate (new Vector3 (0, 0, angleOff));
	}
}