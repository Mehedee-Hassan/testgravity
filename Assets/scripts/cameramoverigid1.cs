using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameramoverigid1 : MonoBehaviour
{
    public GameObject world;

	Rigidbody rigidBody ;
	public float turnSpeed = 10;
	public float rotationForcing = 0f;
	public float rotateForce = 10f;
	public float x, y, z;
	Vector3 diff;
    // Start is called before the first frame update
    void Start()
    {
		///NOTE::
		//get world 

		diff = world.transform.position - transform.position;

		rigidBody = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
		///NOTE::
		//for each update pull this object to the world
		///DEBUG::
		//print("test update");

		navigate();
		move();

		Vector3 direction = world.transform.position - transform.position +diff;
		rigidBody.AddForce(10.0f*direction);




	
	}

	void move()
	{

		//transform.Rotate(new Vector3(rotationForcing, 0.0f, 0f));
		transform.Translate(0f,0f,2f*Time.deltaTime);


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
			transform.Translate(0f, 0f, 5f * Time.deltaTime);
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

		print(transform.eulerAngles.x);
		print(transform.eulerAngles.y);
		print(transform.eulerAngles.z);



	}
}
