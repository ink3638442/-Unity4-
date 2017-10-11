using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rigid : MonoBehaviour {

	Rigidbody rigid;
	GameObject camera;

	// Use this for initialization
	void Start () {
		this.rigid = GetComponent<Rigidbody>();
		this.camera = GameObject.Find("Main Camera");
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.UpArrow))
		{
			this.rigid.AddForce(0, 0, 1);
		}
		if (Input.GetKey(KeyCode.DownArrow))
		{
			this.rigid.AddForce(0, 0, -1);
		}
		if (Input.GetKey(KeyCode.RightArrow))
		{
			this.rigid.AddForce(1, 0, 0);
		}
		if (Input.GetKey(KeyCode.LeftArrow))
		{
			this.rigid.AddForce(-1, 0, 0);
		}
		
		Vector3 pos = transform.position;
		pos.y += 2.5f;
		pos.z -= 3f;
		
		camera.transform.position = pos;
	}
}
