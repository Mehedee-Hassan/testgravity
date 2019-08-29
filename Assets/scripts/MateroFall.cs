using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MateroFall : MonoBehaviour
{

	public GameObject world;
	Rigidbody rigidBody;

   
    void Start()
    {

		if (world == null)
            world = GameObject.FindGameObjectWithTag("world");
		
		rigidBody = this.GetComponent<Rigidbody>();
		DestroyObjectDelayed();


    }

    void Update()
    {
		//Vector3 direction = world.transform.position - transform.position;
		//rigidBody.AddForce(5.0f* direction);
    }

	void FixedUpdate()
	{
	Vector3 direction = world.transform.position - transform.position;
	rigidBody.AddForce(5.0f* direction);
		//Vector3 direction = world.transform.position - transform.position;
		//rigidBody.AddForce(30.0f* direction);
	}

	void DestroyObjectDelayed()
	{
		// Kills the game object in 5 seconds after loading the object
		Destroy(this.gameObject, 10);	 }
}
