using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class car : MonoBehaviour
{

	public GameObject world;

	Rigidbody rigidBody ;
	float turnSpeed = 10;


    // Start is called before the first frame update
    void Start()
    {
		///NOTE::
		//get world 


		rigidBody = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
		///NOTE::
		//for each update pull this object to the world
		///DEBUG::
		//print("test update");


		move();

		Vector3 direction = world.transform.position - transform.position;
		rigidBody.AddForce(10.0f*direction);


		navigate();

	
	}

	void move()
	{

		transform.Translate(0f,0f,2f*Time.deltaTime);

	}

	void navigate() { 
	
		if (Input.GetKey("up"))
		{
			transform.Translate(0f, 0f, 5f * Time.deltaTime);
		}

		if (Input.GetKey("down"))
		{
			transform.Translate(0f, 0f, -5f * Time.deltaTime);
			
		}

		if (Input.GetKey("left"))
		{
			transform.Rotate(Vector3.right, -150f * Time.deltaTime);
			
		}

		if (Input.GetKey("right"))
		{
			transform.Rotate(Vector3.right, 150f*Time.deltaTime);
		}

		print(transform.eulerAngles.x);
		print(transform.eulerAngles.y);
		print(transform.eulerAngles.z);



	}



}
