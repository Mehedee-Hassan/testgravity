using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFollow : MonoBehaviour
{
	public Transform playerTransform;
	public Transform mainObject;
	public Transform followMeObj;
	private Vector3 _cameraOffset;
	private Quaternion _cameraOffsetRotation;
	public float x, y, z, w;

	[Range(0.01f,1f)]
	public float SmoothFactor = 0.1f;

    // Start is called before the first frame update
    void Start()
    {
		//transform.Rotate(new Vector3(34.791f, -44.153f, 1.423f));// = new Quaternion(x,y,z,w);
		
		//_cameraOffset = transform.position - playerTransform.position;
		//_cameraOffsetRotation = mainObject.rotation-playerTransform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
	}

	void FixedUpdate()
	{
		//for car object

		//Vector3 newPosition = playerTransform.position + _cameraOffset;
		//transform.position = Vector3.Slerp(transform.position, newPosition, SmoothFactor);

		/// <summary>
		/// 
		/// for follwo me object
		/// </summary>


		Vector3 newPosition = followMeObj.position ;
		transform.position = Vector3.Lerp(transform.position, newPosition, SmoothFactor);

		//transform.Rotate(new Vector3(34.791f, -44.153f, 1.423f));// = new Quaternion(x,y,z,w);
		transform.LookAt(followMeObj);
		//transform.rotation = Quaternion.Lerp(transform.rotation, _cameraOffsetRotation,Time.deltaTime * 100);
	}
}
