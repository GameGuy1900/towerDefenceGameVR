using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pointsSystem : MonoBehaviour {

	public Text pointstxt;
	public float points;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		pointstxt.text = "" + points;
	}

	public void Addpoint(float pointsV){
		this.points += pointsV;
	}
}
