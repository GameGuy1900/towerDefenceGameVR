using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class PickupFlag : MonoBehaviour {

    [SteamVR_DefaultAction("Squeeze")]
    private SteamVR_TrackedObject trackedObject;

    public bool init;
    public GameObject obj;
    public GameObject hand;


	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {

        if (init)
        {
             if (SteamVR_Input._default.inActions.GrabPinch.GetStateDown(SteamVR_Input_Sources.RightHand))
            {
                Debug.Log("pressed");
                obj.GetComponent<Transform>().parent = hand.transform;
            }
        }
        else
        {
            //nothing 
        }

		
		


	}

	private void OnTriggerEnter(Collider other){
        if(other.tag == "flag")
        {
            init = true;
            obj = other.gameObject;
        }
	}

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "flag")
        {
            init = false;
            obj = null;
        }
    }
}
