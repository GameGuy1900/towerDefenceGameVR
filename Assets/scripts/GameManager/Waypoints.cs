using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waypoints : MonoBehaviour {

	public static Transform[] points;
    
    public int currlength;

	void Awake (){
		points = new Transform[transform.childCount];
		for(int i = 0; i < points.Length; i++){
            currlength = i;
			points[i] = transform.GetChild(i);
		}
	}
}
