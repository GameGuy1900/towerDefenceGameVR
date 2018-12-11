using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class create_towers : MonoBehaviour {

    [SteamVR_DefaultAction("Squeeze")]
    public SteamVR_Action_Single squeezeAction;
    public SteamVR_Action_Vector2 touchPadAction;
    [Header("Tower")]
    public GameObject Tower_obj;
    public GameObject spawner;
    Vector3 pos;
    public Transform trans;




    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //build_towers
        if (SteamVR_Input._default.inActions.GrabPinch.GetStateDown(SteamVR_Input_Sources.RightHand))
        {

            trans.localScale = new Vector3(2f, 2f, 2f);
            GameObject Tower = Instantiate(Tower_obj,trans) as GameObject;
            pos = new Vector3(gameObject.transform.position.x, spawner.transform.position.y, gameObject.transform.position.z);
            Tower.transform.position = pos;
            Tower.transform.parent = null;

        }
    }

   
}
