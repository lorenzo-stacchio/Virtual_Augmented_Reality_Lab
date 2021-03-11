using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Floor : GazeableObject {

	public override void OnPress (RaycastHit hitInfo)
	{
		base.OnPress (hitInfo);

		if (myPlayer.instance.activeMode == InputMode.TELEPORT) {
			Vector3 destLocation = hitInfo.point;
			destLocation.y = myPlayer.instance.transform.position.y;
			myPlayer.instance.transform.position = destLocation;
		}

	}

}
