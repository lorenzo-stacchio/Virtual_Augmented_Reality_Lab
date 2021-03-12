using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Mode : GazeableButton
{
    [SerializeField]
    private InputMode button_mode;

	public override void Start(){
		base.Start();
		representativeMode = button_mode; //assign to father variable this value
	}

    public override void OnPress(RaycastHit hitInfo)
    {
        base.OnPress(hitInfo);
    }

}
