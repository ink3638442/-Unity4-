using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextureController : MonoBehaviour
{
	Texture texture1;
	Color color1;
	GameObject previeText;
	Renderer render;
	private float size = 1.0f;

    // Use this for initialization
    void Start()
    {
		this.previeText = GameObject.Find("PreviewText");
		this.previeText.GetComponent<Text>().text = "TextureSample";
		this.texture1 = (Texture)Resources.Load("GrassHillAlbedo");
		this.render = GetComponent<Renderer>();
		this.color1 = render.material.color;
    }

    // Update is called once per frame
    void Update()
    {
		transform.Rotate(2f, 1.5f, 0.7f);

		// if (Input.GetKeyDown(KeyCode.Space))
		// {
		// 	render.material.mainTexture = texture1;
		// 	render.material.color = Color.white;
		// }

		// if (Input.GetKeyUp(KeyCode.Space))
		// {
		// 	render.material.mainTexture = null;
		// 	render.material.color = color1;
		// }

		render.material.mainTexture = texture1;
		render.material.color = Color.white;

		if (Input.GetKey(KeyCode.LeftArrow))
		{
			this.size += 0.01f;
			render.material.SetTextureScale("_MainTex", new Vector2(size, size));
		}

		if (Input.GetKey(KeyCode.RightArrow))
		{
			this.size -= 0.01f;
			render.material.SetTextureScale("_MainTex", new Vector2(size, size));
		}
    }
}
