using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowR : MonoBehaviour
{

	public GameObject world;
	public GameObject car;
	Vector3 offset;
	public bool MoveCamera = true;

	Vector3 offsetFromW;
	Vector3 offsetOfCar;
	float angleCarW;
	float angleCarc;
	float angleWcam;
	public float x, y, z;
    
	// Start is called before the first frame update
    void Start()
    {
		offset = transform.position- car.transform.position;
		offsetFromW = transform.position- world.transform.position;
		offsetOfCar = world.transform.position - car.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
		//transform.RotateAround(world.transform.position,
		//                      //car.transform.position
		//                       new Vector3(car.transform.rotation.x, car.transform.rotation.x, car.transform.rotation.x)
		//                      , 2f * Time.deltaTime);
		//transform.LookAt(car.transform);

		//transform.LookAt(car.transform, car.transform.up);
		//transform.SetPositionAndRotation(car.transform.position+offset, car.transform.rotation);

		//car to world angle
		angleCarc = Vector3.Angle(car.transform.position, transform.position);
		angleCarW = Vector3.Angle(world.transform.position, car.transform.position);
		angleWcam = Vector3.Angle( world.transform.position,transform.position);

		print("test=angle="+angleCarW+" "+angleCarc+" "+angleWcam);
		//transform.eulerAngles = offsetFromW;


		//transform.position = new Vector3();
		if (MoveCamera == true)
		{

			Vector3 desiredPosition = car.transform.position + offset +offsetFromW;
			//Vector3 desiredPosition = new Vector3(car.transform.position.x+offset.x, car.transform.position.y + offset.y, car.transform.position.z + offset.z);

			//Vector3 desiredPosition = new Vector3(Mathf.Abs(car.transform.position.x) + offset.x, Mathf.Abs(car.transform.position.y) + offset.y, Mathf.Abs(car.transform.position.z) + offset.z);

			Vector3 SmoothedPosition = Vector3.Lerp(transform.position, desiredPosition, 2.0f);
			transform.position = SmoothedPosition;
			//transform.SetPositionAndRotation(SmoothedPosition+new Vector3(x,y,z), world.transform.rotation);
			///transform.LookAt(world.transform);
			transform.Rotate(Vector3.Angle(world.transform.position, car.transform.forward),
			                 Vector3.Angle(world.transform.position, car.transform.right),
			                 Vector3.Angle(world.transform.position, car.transform.up), Space.World);
		}




	}
}
