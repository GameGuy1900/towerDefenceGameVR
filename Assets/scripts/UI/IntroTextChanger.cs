using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Valve.VR;

public class IntroTextChanger : MonoBehaviour {

    public Text PopupMessage;
    public int steps = 0;

    // Use this for initialization
    void Start () {
        steps = 0;
        PopupMessage.text = "Hi there, welcome to Radius TowerDefense! Press \"grip button on either side\" to continue";
    }
	
	// Update is called once per frame
	void Update () {
        if (steps == 0 && SteamVR_Input._default.inActions.GrabGrip.GetStateDown(SteamVR_Input_Sources.Any))
        {
            PopupMessage.text = "Let's get you learning the basics: Press \"Left Trigger\" to use your fireball Press \"grip button on either side\" to continue";
        }
        if (steps == 1 && SteamVR_Input._default.inActions.GrabGrip.GetStateDown(SteamVR_Input_Sources.Any))
        {
            PopupMessage.text = "Good! Now press \"Right Trigger\" to use your iceball Press \"grip button on either side\" to continue";
        }
        if (steps == 2 && SteamVR_Input._default.inActions.GrabGrip.GetStateDown(SteamVR_Input_Sources.Any))
        {
            PopupMessage.text = "Good, now press the \"touchpad\" until you teleport back to the base Press \"grip button on either side\" to continue";
        }
        if (steps == 3 && SteamVR_Input._default.inActions.GrabGrip.GetStateDown(SteamVR_Input_Sources.Any))
        {
            PopupMessage.text = "That was all, you should be good to go now! Press \"grip button to close and\" to continue";
        }
        if (steps == 4 && SteamVR_Input._default.inActions.GrabGrip.GetStateDown(SteamVR_Input_Sources.Any))
        {
            PopupMessage.text = "";
            WaveSpawner wave = new WaveSpawner();
            WaveSpawner waveStarter = wave.GetComponent<WaveSpawner>();
            waveStarter.startCount = true;
        }

        if (SteamVR_Input._default.inActions.GrabGrip.GetStateUp(SteamVR_Input_Sources.Any))
        {
            steps++;
        }
    }
}
