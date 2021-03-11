using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Collect : GazeableObject
{

    [SerializeField]
    private InputMode mode;
	public static bool is_active;

	public void Start(){
		is_active = false;
	}

    public override void OnPress(RaycastHit hitInfo)
    {
        base.OnPress(hitInfo);
        myPlayer.instance.activeMode = InputMode.COLLECT;
    }

	void Update(){
		if (myPlayer.instance.activeMode==InputMode.COLLECT){
			this.GetComponent<Image>().color = Color.green;
		} else {
			this.GetComponent<Image>().color = Color.white;
		}
	}
}
