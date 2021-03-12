using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Teleport_button : GazeableButton
{

	public override void Start(){
		base.Start();
		representativeMode = InputMode.TELEPORT;
	}

    public override void OnPress(RaycastHit hitInfo)
    {
        base.OnPress(hitInfo);
        is_active = true;
    }

}
