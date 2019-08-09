using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraexperi1 : MonoBehaviour
{
	public GameObject car;
	public GameObject world;
	Quaternion rotation,newrotate,temprotation;
	Vector3 pos,newpos,temppos;
	float cartoworld, camtoworld, camtocar;
	Vector3 offCartoWrold, offCamToWordl, offCamToCar;

	Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {

		offCartoWrold = world.transform.position - car.transform.position;
		offCamToWordl = world.transform.position - transform.position;
		offCamToCar = car.transform.position - transform.position;

		cartoworld = Vector3.Angle(world.transform.position, car.transform.position);
		camtoworld = Vector3.Angle(world.transform.position, transform.position);
		camtocar = Vector3.Angle(transform.position, car.transform.position);

		offset = car.transform.position - transform.position;
		rotation = transform.rotation;
		pos = transform.position;
		temprotation = transform.rotation;
		temppos = transform.position;
    }

    // Update is called once per frame
    void Updatejhk()
    {
		newrotate = transform.rotation;
		newpos = transform.position;
		//transform.rotation = rotation;
		//transform.position = pos;


		cartoworld = Vector3.Angle(world.transform.position, car.transform.position);
		camtoworld = Vector3.Angle(world.transform.position, transform.position);
		camtocar = Vector3.Angle(transform.position, car.transform.position);

		//transform.SetPositionAndRotation(car.transform.position + offCamToCar,car.transform.rotation);
		//transform.Translate(car.transform.position + offCamToCar, car.transform);

    }

	void FixedUpdate() {

		//transform.position = Vector3.Slerp(temppos,newpos,14f);
		//transform.rotation = newrotate;

		//transform.position = Vector3.Slerp(temppos,newpos,14f);
		//transform.rotation = newrotate;

		temprotation = transform.rotation;
		temppos = transform.position;  

		//transform.LookAt(car.transform);
	}
}
