using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Struct : MonoBehaviour
{
	struct Hello
	{
		public string name;
		public string maker;
		public int price;

		public Hello(string n, string m, int p)
		{
			name = n;
			maker = m;
			price = p;
		}
	}

	private GameObject previewText;

    // Use this for initialization
    void Start()
    {
		Hello h = new Hello("どら焼き", "和菓子", 125);
		string s = h.name + ","  + h.maker + "," + h.price;
		
		this.previewText = GameObject.Find("PreviewText");
		this.previewText.GetComponent<Text>().text = s;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
