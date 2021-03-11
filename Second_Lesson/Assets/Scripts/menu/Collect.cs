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
        //if (choose_pic_button.is_active)
        //{
            myPlayer.instance.activeMode = InputMode.TELEPORT;
           	is_active = true;
        //}
        //else {
		//	is_active = true;
		//}
		//choose_pic_button.is_active = false;
		//explore_button.is_active = false;
    }

	void Update(){
		if (is_active){
			GameObject teleport_button_ = GameObject.Find("Teleport") as GameObject;
			teleport_button_.GetComponent<Image>().color = Color.green;
		} else {
			GameObject teleport_button_ = GameObject.Find("Teleport") as GameObject;
			teleport_button_.GetComponent<Image>().color = Color.white;
		}
	}
}
