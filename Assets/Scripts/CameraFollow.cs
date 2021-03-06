using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Makes the camera smoothly follow its target (player).
/// </summary>
public class CameraFollow : MonoBehaviour
{
	public Transform target;
	public float smoothing = 5f;

	Vector3 offset;

	void Start ()
	{
		target = GameObject.Find ("Player").GetComponent<Transform> ();
		offset = transform.position - target.position;
	}

	void FixedUpdate ()
	{
		if (target != null) {
			Vector3 targetCamPos = target.position + offset;
			transform.position = Vector3.Lerp (transform.position
			, targetCamPos, smoothing * Time.deltaTime);
		}
	}
}
