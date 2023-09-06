using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour{
	public Transform target;
	private Vector3 offset;

	// Use this for initialization
	private void Start () {
		offset = transform.position - target.position;
	}
	
	// Update is called once per frame
	private void Update () {
		transform.position = new Vector3(target.position.x + offset.x, target.position.y + offset.y, target.position.z + offset.z);
	}
}
