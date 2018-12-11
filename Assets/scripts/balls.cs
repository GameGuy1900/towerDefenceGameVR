using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class balls : MonoBehaviour {

    private float minDmg = 25;
    private float maxDmg = 50;

    private float despawnTimer = 6;


    private void OnTriggerEnter(Collider other)
    {
        float rnd_dmg = Random.Range(minDmg, maxDmg);

        if (other.tag == "enemy")
        {
            other.gameObject.GetComponent<EnemyStats>().TakeDamage(rnd_dmg);
        }
        if (other.tag == "boss")
        {
            other.gameObject.GetComponent<Boss_Stats>().TakeDamage(rnd_dmg);
        }
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        despawnTimer -= Time.deltaTime;
        if(despawnTimer <= 0)
        {
            Destroy(gameObject);
        }
	}
}
