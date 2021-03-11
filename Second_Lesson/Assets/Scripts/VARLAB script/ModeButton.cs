using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModeButton : GazeableButton {

	[SerializeField]
	private InputMode mode;

	public override void OnPress(RaycastHit hitInfo)
	{
		base.OnPress (hitInfo);

		if (parentPanel.currentActiveButton != null) {
			myPlayer.instance.activeMode = mode;
		}
	}


}
