using UnityEngine;
using System.Collections;

public abstract class GameItems : MonoBehaviour {
	public bool interactable;
	public bool zoomable;
	public bool visible;

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

	public abstract void ClickInteraction ();
}
