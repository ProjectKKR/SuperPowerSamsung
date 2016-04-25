using UnityEngine;
using System.Collections;

public abstract class GameItems : MonoBehaviour {
	bool interactable;
	bool zoomable;
	bool visible;

	protected Vector3 zoomCameraLocation;
	public Vector3 ZoomCameraLocation {
		get {
			return zoomCameraLocation;
		}
	}
	protected float distanceThreshold;
	public float DistanceThreshold {
		get {
			return distanceThreshold;
		}
	}

	void get () {
		// TODO compare distance, then call ClickInteraction method
	}
	public abstract void ClickInteraction ();
}
