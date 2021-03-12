using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Collect : GazeableButton
{

	//override method in gazeable button
	public override void Start(){
		base.Start();
        representativeMode = InputMode.COLLECT;
	}

    public override void OnPress(RaycastHit hitInfo)
    {
        base.OnPress(hitInfo);
    }

}
