using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class corgimovement : MonoBehaviour {

	//usage: put this script on a Cylinder in a closed off area
	//intent: make this cylinder ("Corgi") move around

	public bool Pickedup = false; 
	
	// Update is called once per frame
	void Update () {
		
		if (!Pickedup) //! negates
		{
			//step 1: define ray
			Ray corgiRay = new Ray(transform.position, transform.forward);
		
			//step 2: define maximum distance for raycast
			float maxRaycastDistance = .5f;
		
			//step 3: visualize
			Debug.DrawRay(corgiRay.origin, corgiRay.direction * maxRaycastDistance, Color.yellow);
		
			//step 4
			if (Physics.Raycast(corgiRay, maxRaycastDistance))
			{
				//randomly turn left or right?
				int randomNumber = Random.Range(0, 100); //random number from 0-100
				if (randomNumber < 50)
				{//50% chance of turning left
					transform.Rotate(0f, -90f, 0f);

				}
				else
				{
					transform.Rotate(0f, 90f, 0f);
				}
			}
			else
			{
				transform.Translate(0f, 0f, Time.deltaTime);
			}

			if (transform.rotation.eulerAngles.x != 0 || transform.rotation.eulerAngles.z != 0)
			{
				transform.rotation = Quaternion.Euler(0, transform.rotation.eulerAngles.y, 0);
			}
		}
	}
	
}