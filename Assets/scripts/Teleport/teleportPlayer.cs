using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class teleportPlayer : MonoBehaviour {

    public GameObject player;
    public GameObject[] spawnpoint;
    public int currentpos;

	// Use this for initialization
	void Start () {
        spawnpoint = GameObject.FindGameObjectsWithTag("spawnpoint");
        currentpos = spawnpoint.Length;
        player.transform.position = spawnpoint[currentpos].transform.position;
	}
	
	// Update is called once per frame
	void Update () {

        spawnpoint = GameObject.FindGameObjectsWithTag("spawnpoint");

        if (SteamVR_Input._default.inActions.Teleport.GetStateDown(SteamVR_Input_Sources.Any))
        {
            currentpos += 1;

            if(currentpos > spawnpoint.Length - 1)
            {
                currentpos = 0;
            }

            if(currentpos < 0)
            {
                currentpos = spawnpoint.Length - 1;
            }

            player.transform.position = spawnpoint[currentpos].transform.position;
        }

	}
}
