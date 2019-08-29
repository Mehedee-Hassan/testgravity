using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

	public GameObject[] meteors;
	public Vector3 spawnValue;
	public float spawnWait;
	public float spawnMostWait;
	public float spawnLeastWait;
	public float startWait;
	public bool stop = false;
	int randomMateor;

    void Start()
    {
		StartCoroutine(waitSpawner());
    }

    void Update()
    {
		spawnWait = Random.Range(spawnLeastWait,spawnMostWait);
    }


	IEnumerator waitSpawner()
	{

		yield return new WaitForSeconds(spawnWait);
		int minus = 1;

		while (!stop) 
		{
			randomMateor = Random.Range(0, 2);



			Vector3 spawnPosition = new Vector3(Random.Range(-spawnValue.x,spawnValue.x),Random.Range(-spawnValue.y,-6),Random.Range(-spawnValue.z,spawnValue.z));

			if (minus == 1)
			{
				spawnPosition = new Vector3(Random.Range(-spawnValue.x, spawnValue.x),Random.Range(6, spawnValue.y), Random.Range(-spawnValue.z, spawnValue.z));
				minus ++;
			}
			else if (minus == 2)
			{
				spawnPosition = new Vector3(Random.Range( -spawnValue.x,-6),Random.Range(-spawnValue.y, spawnValue.y), Random.Range(-spawnValue.z, spawnValue.z));
				minus ++;
			}
			else if (minus == 4)
			{

				spawnPosition = new Vector3(Random.Range(6,spawnValue.x ),Random.Range( -spawnValue.y,spawnValue.y), Random.Range(-spawnValue.z, spawnValue.z));
				minus++;
			}
			else if (minus == 5)
			{
				spawnPosition = new Vector3(Random.Range(-spawnValue.x, spawnValue.x),Random.Range(-spawnValue.y, spawnValue.y), Random.Range(-spawnValue.z,-6));
				minus++;
			}
			else if (minus == 6)
			{

				spawnPosition = new Vector3(Random.Range(-spawnValue.x, spawnValue.x),Random.Range(-spawnValue.y, spawnValue.y), Random.Range(6, spawnValue.z));
				
				minus++;
			}

			else if (minus == 7)
			{
				spawnPosition = new Vector3(Random.Range(-spawnValue.x, spawnValue.x),Random.Range(6, spawnValue.y), Random.Range(6, spawnValue.z));
				minus++;
			}
			else if (minus == 8)
			{

				spawnPosition = new Vector3(Random.Range(-spawnValue.x, spawnValue.x),Random.Range(-spawnValue.y,-6), Random.Range(-spawnValue.z,-6));
				
				minus++;
			}

			else if (minus == 9)
			{

				spawnPosition = new Vector3(Random.Range(6, spawnValue.x),	Random.Range(-spawnValue.y, spawnValue.y), Random.Range(6, spawnValue.z));
				
				minus++;
			}
			else if (minus == 10)
			{

				spawnPosition = new Vector3(Random.Range(-spawnValue.x, 6),	Random.Range(-spawnValue.y,spawnValue.y), Random.Range(-spawnValue.z,-6));
				
				minus++;
			}
			else if (minus == 11)
			{

				spawnPosition = new Vector3(Random.Range(6, spawnValue.x),	Random.Range(-spawnValue.y, 6), Random.Range(-spawnValue.z, spawnValue.z));
				
				minus++;
			}
			else if (minus == 12)
			{

				spawnPosition = new Vector3(Random.Range(-spawnValue.x, 6),Random.Range(6,spawnValue.y), Random.Range(-spawnValue.z,spawnValue.z));
				
				minus++;
			}
			else
				minus = 1;

            Instantiate(meteors[randomMateor], spawnPosition+ transform.TransformPoint(0.99f, 0.38f,-6),gameObject.transform.rotation);
			yield return new WaitForSeconds(0.5f);
			Instantiate(meteors[randomMateor],spawnPosition+ transform.TransformPoint(-0.99f, -0.38f,6),gameObject.transform.rotation);
		    yield return new WaitForSeconds(spawnWait);
			
		}

	}
}
