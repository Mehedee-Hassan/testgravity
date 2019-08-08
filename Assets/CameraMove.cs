using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
	public GameObject world; 
	public GameObject car;

	Rigidbody rigidBody ,rigidBody2;
	float turnSpeed = 10,FixeScale=1f;
	Vector3 pos;

	// Start is called before the first frame update
	void Start()
	{
		///NOTE::
		//get world 


		rigidBody = this.GetComponent<Rigidbody>();
		rigidBody2 = car.GetComponent<Rigidbody>();
	}

	// Update is called once per frame
	void Update()
	{
	//	move();
	//	pos = rigidBody.transform.position - car.transform.position;
 		//transform.localScale = new Vector3 (FixeScale/rigidBody2.transform.localScale.x,FixeScale/rigidBody2.transform.localScale.y,FixeScale/rigidBody2.transform.localScale.z);
   

	}

	void move()
	{

	//	Vector3 pos = rigidBody.transform.position - car.transform.position;


	}
	void LateUpdate()
	{
	//	transform.Translate(rigidBody.transform.position-pos);
	}

}
