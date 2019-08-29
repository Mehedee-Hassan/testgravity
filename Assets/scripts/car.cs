using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class car : MonoBehaviour
{

	public GameObject world;
	public GameObject camera1;

	Rigidbody rigidBody ;
	public float turnSpeed = 10;
	public float rotationForcing = 0f;
	public float rotateForce = 10f;
	public float x, y, z;
	public float t1,t2;
    // Start is called before the first frame update
    void Start()
    {
		///NOTE::
		//get world 


		rigidBody = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
		///NOTE::
		//for each update pull this object to the world
		///DEBUG::
		//print("test update");


		move();
		navigate();

		Vector3 direction = world.transform.position - transform.position;
		rigidBody.AddForce(t1*direction);



		print(transform.rotation + "local " + transform.localRotation);


	

	
	}

	void move()
	{

		//transform.Rotate(new Vector3(rotationForcing, 0.0f, 0f));
		//transform.Translate(0f,0f,8f*Time.deltaTime);
		transform.Translate(0f,0f,t2*Time.deltaTime);


		/*transform.RotateAround(world.transform.position, 
		                       //new Vector3(rotationForcing, 0f, 1f)
		                       //new Vector3(transform.position.x, transform.position.y, transform.position.z)
		                       //Vector3.up
		                       new Vector3(transform.rotation.x,transform.rotation.x,transform.rotation.x)
		                       , rotateForce * Time.deltaTime);
		rotationForcing = 0f;*/
	}

	void navigate() { 
	
		if (Input.GetKey("up"))
		{
			transform.Translate(0f, 0f, 2f * Time.deltaTime);
		}

		if (Input.GetKey("down"))
		{
			transform.Translate(0f, 0f, -5f * Time.deltaTime);
			
		}

		if (Input.GetKey("left"))
		{
			//rotationForcing = 0.5f;
			transform.Rotate(Vector3.right, -150f * Time.deltaTime);
			
		}

		if (Input.GetKey("right"))
		{
			//rotationForcing = -0.5f;
			transform.Rotate(Vector3.right, 150f*Time.deltaTime);
		}

		float translation = Input.GetAxis("Vertical") ;
		float rotation = Input.GetAxis("Horizontal") ;


		print(transform.eulerAngles.x+" "+translation+" "+rotation);
		print(transform.eulerAngles.y);
		print(transform.eulerAngles.z);



	}



}
