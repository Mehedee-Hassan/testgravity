using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFollow : MonoBehaviour
{
	public Transform playerTransform;
	public Transform mainObject;
	private Vector3 _cameraOffset;
	private Quaternion _cameraOffsetRotation;


	[Range(0.01f,1f)]
	public float SmoothFactor = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
		_cameraOffset = transform.position - playerTransform.position+(mainObject.position-playerTransform.position);
		//_cameraOffsetRotation = mainObject.rotation-playerTransform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
	}

	void LateUpdate()
	{
		Vector3 newPosition = playerTransform.position + _cameraOffset;
		transform.position = Vector3.Slerp(transform.position, newPosition, SmoothFactor);

		//transform.rotation = Quaternion.Lerp(transform.rotation, _cameraOffsetRotation,Time.deltaTime * 100);
	}
}
