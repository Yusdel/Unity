using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{
	public float speed;
	private Renderer renderer;
    // Start is called before the first frame update
    void Awake()
    {
    	renderer = gameObject.GetComponent<Renderer>();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    	float offset = speed * Time.deltaTime;
    	Vector2 oldTexture = renderer.material.GetTextureOffset("_MainTex");
        renderer.material.SetTextureOffset("_MainTex", new Vector2(0.0f, oldTexture.y + offset));
    }

    void FixedUpdate()
    {

    }
}
