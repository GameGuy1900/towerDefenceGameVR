using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class ViveInput : MonoBehaviour {

    [SteamVR_DefaultAction("Squeeze")]
    public SteamVR_Action_Single squeezeAction;
    public SteamVR_Action_Vector2 touchPadAction;
    [Header("Fireball")]
    public GameObject fireball_obj;
    public float fireball_speed;
    [Header("Iceball")]
    public GameObject Iceball_obj;
    public float iceball_speed;
    [Header("hands")]
    public GameObject Lefthand;
    public GameObject Righthand;

    public float cooldown;
    float cooldownTimer;
    float cooldownTimer_right;

    void Update () {

        if(cooldownTimer > 0)
        {
            cooldownTimer -= Time.deltaTime;
        }
		
        if(cooldownTimer < 0)
        {
            cooldownTimer = 0;
        }

        if (cooldownTimer_right > 0)
        {
            cooldownTimer_right -= Time.deltaTime;
        }

        if (cooldownTimer_right < 0)
        {
            cooldownTimer_right = 0;
        }

        //fireball
        if (SteamVR_Input._default.inActions.GrabPinch.GetStateDown(SteamVR_Input_Sources.LeftHand) && cooldownTimer == 0)
        {
            GameObject fireball = Instantiate(fireball_obj, Lefthand.transform) as GameObject;
            fireball.transform.parent = null;
            Rigidbody rb = fireball.GetComponent<Rigidbody>();
            rb.velocity = Lefthand.transform.forward * fireball_speed;
            cooldownTimer = cooldown;
            
        }
        //iceball
        if (SteamVR_Input._default.inActions.GrabPinch.GetStateDown(SteamVR_Input_Sources.RightHand) && cooldownTimer_right == 0)
        {
            GameObject iceball = Instantiate(Iceball_obj, Righthand.transform) as GameObject;
            iceball.transform.parent = null;
            Rigidbody rb2 = iceball.GetComponent<Rigidbody>();
            rb2.velocity = Righthand.transform.forward * iceball_speed;
            cooldownTimer_right = cooldown;
        
        }







    }
}
