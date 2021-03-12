using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


[RequireComponent(typeof(Image))]

/*
This class as its aim goal that of define the process to controll a Button item with gazer. 
We suppose that a Button will always lies within a Menu identified by VRCanvas parentPanel. 

*/


public class GazeableButton : GazeableObject {

	protected VRCanvas parentPanel;
	protected InputMode representativeMode;


	// Use this for initialization
	public virtual void Start () {
		parentPanel = GetComponentInParent<VRCanvas> ();
	}

	public void SetButtonColor(Color buttonColor)
	{
		GetComponent<Image>().color = buttonColor;
	}

	public InputMode getRepresentativeMode(){
		return representativeMode;
	}

	public override void OnPress(RaycastHit hitInfo)
	{
		base.OnPress (hitInfo);
		if (parentPanel != null) {
			parentPanel.SetActiveButton (this);
			Debug.Log("activate" + this.ToString());
		} else {
			Debug.LogError ("Button not a child of object with VRPanel component. ", this);
		}

	}

}
