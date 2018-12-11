using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class allowedTobuild : MonoBehaviour {

    public GameObject can;
    public GameObject cant;

	// Use this for initialization
	void Start () {
        cant.SetActive(true);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "towerbuilder")
        {
            can.SetActive(true);
            cant.SetActive(false);
        }
    }
        
    void OnTriggerExit(Collider other)
    {
        if (other.tag == "towerbuilder")
        {
            can.SetActive(false);
            cant.SetActive(true);
        }
    }
}
