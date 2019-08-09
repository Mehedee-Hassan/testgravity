using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class worldmove : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

		transform.Rotate(new Vector3(0f, 0f, 10f * Time.deltaTime));
		navigate();
    }

	void navigate()
	{

		if (Input.GetKey("up"))
		{
			transform.Rotate(new Vector3(0f, 0f, 12f * Time.deltaTime));
		}

		if (Input.GetKey("down"))
		{
			transform.Rotate(new Vector3(0f, 0f, 12f * Time.deltaTime));

		}

		if (Input.GetKey("left"))
		{
			//rotationForcing = 0.5f;
			transform.Rotate(Vector3.right, -150f * Time.deltaTime);

		}

		if (Input.GetKey("right"))
		{
			//rotationForcing = -0.5f;
			transform.Rotate(Vector3.right, 150f * Time.deltaTime);
		}

		float translation = Input.GetAxis("Vertical");
		float rotation = Input.GetAxis("Horizontal");


		print(transform.eulerAngles.x + " " + translation + " " + rotation);
		print(transform.eulerAngles.y);
		print(transform.eulerAngles.z);



	}

}
