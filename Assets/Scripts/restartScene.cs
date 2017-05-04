using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class restartScene : MonoBehaviour {

	void OnTriggerEnter (Collider other) 
	{
		if(other.name == "restart")
		{
			//Application.LoadLevel ("ambient test");
			SceneManager.LoadScene ("ambient test");
		}
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
