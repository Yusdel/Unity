using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
	public float speed;
	public GameObject explosion;

	private Rigidbody rb;
    // Start is called before the first frame update
    
	private void Awake()
	{
		rb = GetComponent<Rigidbody>();
	}

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {	
    	
    	/*float offsetX = speed * moveHorizontal * Time.deltaTime;
    	float offsetZ = speed * moveVertical * Time.deltaTime;

    	transform.position = new Vector3(
    		transform.position.x + offsetX,
    		transform.position.y,
    		transform.position.z + offsetZ);*/
        
    }
    void FixedUpdate()
    {
    	float moveHorizontal = Input.GetAxis("Horizontal");
    	float moveVertical = Input.GetAxis("Vertical");

    	Vector3 movement = new Vector3(moveHorizontal,0.0f,moveVertical);
    	rb.velocity = speed*movement;
    }

    void OnTriggerEnter(Collider other)
    {
    	if(other.tag == "Enemy")
    	{
    			Instantiate(explosion,transform.position,transform.rotation);
    			Destroy(gameObject);
    		
    	}
    }
}
