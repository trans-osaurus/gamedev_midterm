﻿using System.Collections;
         using System.Collections.Generic;
         using UnityEngine;
         using UnityEngine.SceneManagement;
         
         public class Win : MonoBehaviour
         {
         
         	public Collider pencollider; 
         
         	// Use this for initialization
         	void Start () {
         		
         	}
         	
         	// Update is called once per frame
         	void Update () {
         		if (corgitrigger.corgisfound == 3)
         
         		{
         			SceneManager.LoadScene("winscene");
         		
         		}
         		
         		
         	}
       
         	//add a found/not bool to the corgis so they don't get found twice 
	}

