using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DroppedPlace : MonoBehaviour
{

	public GameObject target;
    // Start is called before the first frame update
    void Start()
    {
		Vector3 relativePos = target.transform.position - transform.position;

		// the second argument, upwards, defaults to Vector3.up
		Quaternion rotation = Quaternion.LookRotation(relativePos,Vector3.up );
		transform.rotation = rotation;
		//transform.Rotate (0,0,90);


		//transform.LookAt(target.transform);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
