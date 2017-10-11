using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BillardsController : MonoBehaviour
{
	float dgr = 0;
	int shotPower = 0;
	Vector3 ballPos;
	Vector3 shotVec;
	Rigidbody rigid;

    // Use this for initialization
    void Start()
    {
		this.rigid = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
		this.ballPos = transform.position;

		if (Input.GetKeyDown(KeyCode.Space))
		{
			this.shotPower = 0;
		}

		if (Input.GetKey(KeyCode.Space))
		{
			this.shotPower += 5;
		}

		if (Input.GetKeyUp(KeyCode.Space))
		{
			this.shotVec = (Camera.main.transform.position - ballPos);
			this.shotVec = shotVec * shotPower * -1;
			this.shotVec.y = 0;
			this.rigid.AddForce(shotVec);
		}

		if (Input.GetKey(KeyCode.LeftArrow))
		{
			Camera.main.transform.RotateAround(ballPos, new Vector3(0, 10, 0), -1f);
			this.dgr += 1f;
		}

		if (Input.GetKey(KeyCode.RightArrow))
		{
			Camera.main.transform.RotateAround(ballPos, new Vector3(0, 10, 0), 1f);
			this.dgr -= 1f;
		}

		float d = (2 * Mathf.PI) * (dgr / 360);
		float x = Mathf.Sin(d);
		float y = Mathf.Cos(d);

		// カメラポジション
		// 1単位円から10倍にする
		x *= 10f;
		y *= 10f;

		Camera.main.transform.position = new Vector3(ballPos.x + x, ballPos.y + 10f, ballPos.z - y);
    }
}
