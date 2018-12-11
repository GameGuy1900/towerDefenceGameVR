using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour {

    public float lookRadius = 10f;

    public float speed = 10f;

    private Transform target;
    private int wavepointIndex = 0;
    
    //Enemy dmg
    private float minDmg = 0.05f;
    private float maxDmg = 0.06f;

    public bool init;
    GameObject obj;


    private void OnTriggerEnter(Collider other)
    {

        if (other.tag == "base")
        {
            obj = other.gameObject;
            init = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "base")
        {
            init = false;
        }
    }


    // Use this for initialization
    void Start ()
    {
		target = Waypoints.points[0];
	}
	
	// Update is called once per frame
	void Update ()
    {

        if (init)
        {
            float rnd_dmg = Random.Range(minDmg, maxDmg);
            obj.GetComponent<BaseStats>().TakeDamage(rnd_dmg);
        }

        Vector3 dir = target.position - transform.position;
        transform.Translate(dir.normalized * speed * Time.deltaTime, Space.World);

        if (Vector3.Distance(transform.position, target.position) <= 0.4f){
            GetNextWaypoint();
        }
	}

    void OnDrawGizmosSelected ()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, lookRadius);
    }

    void GetNextWaypoint ()
    {

        if (wavepointIndex >= Waypoints.points.Length - 1)
        {
            
            return;
        }

        wavepointIndex++;
        target = Waypoints.points[wavepointIndex];
    }
}
