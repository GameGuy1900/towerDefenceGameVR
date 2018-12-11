using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Boss_Stats : MonoBehaviour {

    //Health
    public float maxHealth = 500f;
    public float currentHealth;

    public Canvas healthbarcanvas;
    public Image img;
    private Camera cameraToLookAt;

    private void Start()
    {
        currentHealth = maxHealth;
        cameraToLookAt = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        if (currentHealth <= 0f)
        {
            //Death animation script
            Destroy(gameObject);
        }

        img.fillAmount = currentHealth / maxHealth;

        // healthbar looks at player
        Vector3 v = cameraToLookAt.transform.position - transform.position;
        v.x = v.z = 0.0f;
        healthbarcanvas.transform.LookAt(cameraToLookAt.transform.position - v);
        healthbarcanvas.transform.rotation = Quaternion.LookRotation(-cameraToLookAt.transform.forward, cameraToLookAt.transform.up);
    }

    public void TakeDamage(float rndDmg)
    {
        currentHealth -= rndDmg;
    }
}
