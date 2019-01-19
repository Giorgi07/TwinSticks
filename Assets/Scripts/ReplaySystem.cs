using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReplaySystem : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

public struct MyKeyFrame {

	public float frameTime;
	public Vector3 position;
	public Quaternion rotation;

	MyKeyFrame(float aTime, Vector3 aPosition, Quaternion aRotation) {
		frameTime = aTime;
		position = aPosition;
		rotation = aRotation;
	}

}
