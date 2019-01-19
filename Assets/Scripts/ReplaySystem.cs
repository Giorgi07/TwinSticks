using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReplaySystem : MonoBehaviour {


	private const int bufferFrames = 1000;
	private MyKeyFrame[] keyframes = new MyKeyFrame[bufferFrames];
	private Rigidbody myrigidbody;
	private GameManager manager;

	// Use this for initialization
	void Start () {
		myrigidbody = GetComponent<Rigidbody> ();
		manager = GameObject.FindObjectOfType<GameManager> ();
	}
		
	void Update () {
		if (manager.recording) {
			Record ();
		} else {
			PlayBack ();
		}
	}

	void PlayBack() {
		myrigidbody.isKinematic = true;
		int frame = Time.frameCount % bufferFrames;
		transform.position = keyframes [frame].position;
		transform.rotation = keyframes [frame].rotation;
	}

	void Record ()
	{
		myrigidbody.isKinematic = false;
		int frame = Time.frameCount % bufferFrames;
		float time = Time.time;
		keyframes [frame] = new MyKeyFrame (time, transform.position, transform.rotation);
	}

}
/// <summary>
/// A structure for storing time,rotation and position
/// </summary>
public class MyKeyFrame {

	public float frameTime;
	public Vector3 position;
	public Quaternion rotation;

	public MyKeyFrame (float _Time, Vector3 _position, Quaternion _rotation) {
		_Time = frameTime;
		_position = position;
		_rotation = rotation;
	}

}
