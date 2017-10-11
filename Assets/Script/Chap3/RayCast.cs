using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCast : MonoBehaviour {

	Vector3 stdSize;
    Vector3 smlSize;
    RaycastHit hit;
    int counter = 0;
    bool flg = false;

    // Use this for initialization
    void Start()
    {
        this.stdSize = new Vector3(1f, 1f, 1f);
        this.smlSize = new Vector3(0.5f, 0.5f, 0.5f);
    }

    // Update is called once per frame
    void Update()
    {
		if (flg)
		{
			if (counter <= 0)
			{
				hit.transform.localScale = stdSize;
				flg = false;
			}
			else
			{
				counter--;
			}
		}

		if (Input.GetMouseButtonDown(0))
		{
			Vector3 pos = Input.mousePosition;
			pos.z = 3.0f;

			Ray ray = Camera.main.ScreenPointToRay(pos);
			if (!flg)
			{
				if (Physics.Raycast(ray, out hit, 100))
				{
					hit.transform.localScale = smlSize;
					counter = 10;
					flg = true;
				}
				else
				{
					Vector3 newpos = Camera.main.ScreenToWorldPoint(pos);
					transform.position = newpos;
				}
			}

		}
    }
}
