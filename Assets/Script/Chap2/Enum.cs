using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enum : MonoBehaviour
{
	private GameObject previewText;

	enum Hello {Hello, Oha, Yo};

    // Use this for initialization
    void Start()
    {
		this.previewText = GameObject.Find("PreviewText");

		Hello h = Hello.Yo;
		switch(h)
		{
			case Hello.Hello:
			this.previewText.GetComponent<Text>().text = "ハロー";
			break;

			case Hello.Oha:
			this.previewText.GetComponent<Text>().text = "おはー";
			break;

			case Hello.Yo:
			this.previewText.GetComponent<Text>().text = "よー";
			break;
		}
    }

    // Update is called once per frame
    void Update()
    {
		
    }
}
