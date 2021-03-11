using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GazeableObject : MonoBehaviour {

	// flag: can i transform the selected object?
	public bool isTransformable = false;

	// variables for GazeTranslate
	private int objectLayer;
	private const int IGNORE_RAYCAST_LAYER = 2;

	// variables for GazeRotate
	private Vector3 initialObjectRotation;
	private Vector3 initialPlayerRotation;

//	// variables for GazeScale
//	private Vector3 initialObjectScale;


	public virtual void OnGazeEnter(RaycastHit hitInfo)
	{
		//Debug.Log ("Gaze entered on " + gameObject.name); 
	}

	public virtual void OnGaze(RaycastHit hitInfo)
	{
		//Debug.Log ("Gaze hold on " + gameObject.name); 
	}
	 
	public virtual void OnGazeExit()
	{
		//Debug.Log ("Gaze exited on " + gameObject.name); 
	}


	public virtual void OnPress(RaycastHit hitInfo)
	{
		//Debug.Log ("Button pressed"); 
		if (isTransformable) {
			
			// set for GazeTranslate
			objectLayer = gameObject.layer; //save here initial value
			//gameObject.layer = IGNORE_RAYCAST_LAYER;

			// set for GazeRotate
			initialObjectRotation = transform.rotation.eulerAngles;
			initialPlayerRotation = Camera.main.transform.eulerAngles;

			// set for GazeScale
//			initialObjectScale = transform.localScale;
		}
	}


	public virtual void OnHold(RaycastHit hitInfo)
	{
		//Debug.Log ("Button hold"); 
		if (isTransformable) {
			GazeTranform (hitInfo);
			//Debug.Log ("GazeTranform done");
		}
	}


	public virtual void OnRelease(RaycastHit hitInfo)
	{
		//Debug.Log ("Button released" ); 
		if (isTransformable) {
			//gameObject.layer = objectLayer; //back to initial value
		}
		 
	}


	public virtual void GazeTranform (RaycastHit hitInfo)
	{

		switch (myPlayer.instance.activeMode) 
		{

/*		case InputMode.TRANSLATE:   //move the obj (change position)
			GazeTranslate (hitInfo);
			break;
		case InputMode.ROTATE: 	//change the object orientation 
			GazeRotate (hitInfo);
			break;
		case InputMode.SCALE: //make the object bigger/smaller
			GazeScale (hitInfo);
			break;
*/		}
	}


	public virtual void GazeTranslate (RaycastHit hitInfo) // to translate an isTransformable object
	{
		if (hitInfo.collider != null && hitInfo.collider.GetComponent<MoveableArea> ()) {
			
			transform.position = hitInfo.point; 

		}


	}

	public virtual void GazeRotate (RaycastHit hitInfo) // to rotate an isTransformable object
	{
		float rotationSpeed = 10.0f ;
		Vector3 currentPlayerRotation = Camera.main.transform.rotation.eulerAngles; // 3 rotation components of Camera
		Vector3 currentObjectRotation = transform.rotation.eulerAngles; // 3 rotation components from Inspector
		Vector3 rotationDelta = currentPlayerRotation - initialPlayerRotation; // it corresponds to the effective head rotation
		// rotation is olny around Y 
		Vector3 newRotation = new Vector3 (currentObjectRotation.x, initialObjectRotation.y+(rotationSpeed*rotationDelta.y), currentObjectRotation.z); // .x e .z componets do not change
		// execution of newRotation
		transform.rotation = Quaternion.Euler(newRotation);
	}


}
