using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BaseStats : MonoBehaviour {

    //Health
    private float maxHealth = 200f;
    private float currentHealth;

    public Image img;
    public GameObject gamemaker;


    // Use this for initialization
    void Start () {
        currentHealth = maxHealth;
	}
	
	// Update is called once per frame
	void Update () {
        if (currentHealth <= 0f)
        {
            //Game over script
            gamemaker.GetComponent<gameMaker>().EndGame();
        }

        img.fillAmount = currentHealth / maxHealth;
    }

    public void TakeDamage(float rndDmg)
    {
        currentHealth -= rndDmg;
    }
}
