using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VRCanvas : MonoBehaviour {

	public GazeableButton currentActiveButton;
	public Color unselectedColor = Color.white;
	public Color selectedColor = Color.green;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		LookAtPlayer ();
	}


	public void SetActiveButton(GazeableButton activeButton)
	{
		// If there was previously active button, disable it
		if (currentActiveButton != null) {
			//set player mode to none and change color button
			currentActiveButton.SetButtonColor(unselectedColor);
			myPlayer.instance.activeMode = InputMode.NONE;
		}
		if (activeButton != null && currentActiveButton != activeButton) {
			currentActiveButton = activeButton;
			currentActiveButton.SetButtonColor(selectedColor);
			myPlayer.instance.activeMode = activeButton.getRepresentativeMode();
			//Debug.Log("player setting in VR CANVAS" + myPlayer.instance.activeMode.ToString());
		} else {
			//Debug.Log ("Resetting");
			currentActiveButton = null;
			myPlayer.instance.activeMode = InputMode.NONE;
		}
	}

	public void LookAtPlayer()
	{
		Vector3 playerPos = myPlayer.instance.transform.position; //player position
		Vector3 vecToPlayer = playerPos - transform.position; //distance between the player and the VRCanvas
		Vector3 lookAtPos = transform.position - vecToPlayer; //position vector used in the lookAt method  
		//Debug.Log("player pos" + playerPos.ToString());
		//Debug.Log("vecToPlayer" + vecToPlayer.ToString());
		//Debug.Log("lookAtPos" + lookAtPos.ToString());
		// Rotate the Menu so it keeps looking at the player
		transform.LookAt (lookAtPos);
	}

}
