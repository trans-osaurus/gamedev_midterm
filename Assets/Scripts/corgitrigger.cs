using System.Collections;
using System.Collections.Generic;
using System.Net.Mime;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;
using UnityEngine.UI;
//using UnityEngine.SceneManagement; 

//place this script on the trigger object, in this case it's the floor of the pen 
// this will count the number of corgis found 

public class corgitrigger : MonoBehaviour
{

	public Text myTextDisplay;
	public Collider corgicollider;
	public static int corgisfound = 0;



	// Use this for initialization
	void Start()
	{
		myTextDisplay.text = "Find all the missing corgi puppies!";

	}

	// Update is called once per frame
	void Update()
	{
		





	}

	void OnTriggerEnter(Collider corgicollider)
	{
		if (corgicollider.gameObject.CompareTag("Corgi"))
		{
			corgisfound++;
			myTextDisplay.text = "Corgis found:" + corgisfound.ToString();
			//corgicollider.GetComponent<Rigidbody>().isKinematic = true;

		}
		
	}

}