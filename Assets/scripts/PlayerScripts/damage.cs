using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class damage : MonoBehaviour {

	public GameObject pointsSystem;
	public float pointValue;
	
	

	// Use this for initialization
	void Start () {
        pointsSystem = GameObject.FindWithTag("pointsUI").gameObject;
	}
	
	// Update is called once per frame
	void Update () {
		//Destroy(GameObject.FindWithTag("enemy"));
		//OnTriggerEnter(GameObject.FindWithTag("enemy").GetComponent<CapsuleCollider>());
	}

	public void OnTriggerEnter(Collider other) {

		if(other.tag == "enemy"){
			
			pointsSystem.GetComponent<pointsSystem>().Addpoint(pointValue);
			//Destroy(other.gameObject);
		}
	}


}
