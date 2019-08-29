using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MDropCollistion : MonoBehaviour
{
		
		public Transform explosionPrefab;
	    //public GameObject m1;


		void OnCollisionEnter(Collision collision)
		{
			if (collision.gameObject.tag.Equals("mateor"))
			{
				ContactPoint contact = collision.contacts[0];
				Quaternion rot = Quaternion.FromToRotation(Vector3.up, contact.normal);
				Vector3 pos = contact.point;
				Transform test = Instantiate(explosionPrefab, pos, rot);
                Destroy(collision.gameObject);
				Destroy(test.gameObject, 5f);
			}
		}
    
}
