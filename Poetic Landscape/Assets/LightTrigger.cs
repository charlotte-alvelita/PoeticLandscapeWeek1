using UnityEngine;
using System.Collections;

public class LightTrigger : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Debug.Log ( "This is from the start, ok?" );
		
		gameObject.GetComponent<Light>().enabled = true; 
	}
	
	// Update is called once per frame
	void Update () { 
	
	}
	//when the player walks into the rigger on this gameobject
	void OnTriggerEnter() {
		//get the light component on this game object, turn it off
		gameObject.GetComponent<Light> ().enabled = false; 

	}
	void OnTriggerExit(){
		//get the light component on this game object, turn it on
		gameObject.GetComponent<Light> ().enabled = true; 
	}
	void OnTriggerEnter(){
		gameObject
	}
