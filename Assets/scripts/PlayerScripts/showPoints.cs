using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Valve.VR;

public class showPoints : MonoBehaviour {

    [SteamVR_DefaultAction("Squeeze")]
    public SteamVR_Action_Single InteractUI;

    public GameObject canvas;
    public bool isOpen;

    // Use this for initialization
    void Start () {
        isOpen = false;
	}
	
	// Update is called once per frame
	void Update () {

        if(SteamVR_Input._default.inActions.InteractUI.GetStateDown(SteamVR_Input_Sources.LeftHand)){
            
            if(isOpen == false)
            {
                isOpen = true;
            }
            else
            {
                isOpen = false;
            }

        }

        if (!isOpen)
        {
            canvas.GetComponent<Canvas>().enabled = false;
        }
        else
        {
            canvas.GetComponent<Canvas>().enabled = true;
        }

    }
}
