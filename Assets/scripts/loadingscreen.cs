using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class loadingscreen : MonoBehaviour {

    public float timer = 6;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        timer -= Time.deltaTime;

        if(timer <= 0)
        {
            Application.LoadLevel(Application.loadedLevel + 1);
 
        }

	}
}
