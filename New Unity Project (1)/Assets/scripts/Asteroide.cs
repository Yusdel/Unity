using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroide : MonoBehaviour
{
	public float speed;
	public GameObject explosion;
	private Rigidbody rb;
    // Start is called before the first frame update
    void Awake()
    {
    	rb = GetComponent<Rigidbody>();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void FixedUpdate()
    {
    	float moveHorizontal = Input.GetAxis("Horizontal");
    	float moveVertical = Input.GetAxis("Vertical");

    	Vector3 movement = new Vector3(0.0f ,0.0f, -1.0f*Time.fixedDeltaTime);
    	rb.velocity = speed*movement;
    }

    void OnTriggerEnter(Collider other)
    {
    	if(other.tag == "Player" || other.tag == "playershot")
    	{
    			Instantiate(explosion,transform.position,transform.rotation);
    			Destroy(gameObject);
    		
    	}
    }
}
