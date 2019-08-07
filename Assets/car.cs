using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class car : MonoBehaviour
{

	public GameObject world;
	Rigidbody rigidBody ;

    // Start is called before the first frame update
    void Start()
    {
		///NOTE::
		//get world 


		rigidBody = GetComponent<Rigidbody>();
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
		rigidBody.AddForce(2.0f*direction);


	
	}

	void move()
	{
		transform.Translate(0f,0f,1f*Time.deltaTime);



	}



}
