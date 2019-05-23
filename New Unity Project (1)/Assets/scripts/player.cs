using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
	public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    	float moveHorizontal = Input.GetAxis("Horizontal");
    	float moveVertical = Input.GetAxis("Vertical");
    	float offsetX = speed * moveHorizontal * Time.deltaTime;
    	float offsetZ = speed * moveVertical * Time.deltaTime;

    	transform.position = new Vector3(
    		transform.position.x + offsetX,
    		transform.position.y,
    		transform.position.z + offsetZ);
        
    }
}
