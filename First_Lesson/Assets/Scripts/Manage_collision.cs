using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manage_collision : MonoBehaviour
{
    //Declare variable to manipulate the material of the object
    MeshRenderer thisRenderer; 
    Vector3 startPosition;
    float velocity = 1.0E-0f;
    int left_right;
    // Start is called before the first frame update

    void Start()
    {
        //init the render responsible for this object
        thisRenderer = GetComponent<MeshRenderer>();
        startPosition = this.transform.position;
        //Fetch the GameObject's Collider (make sure they have a Collider component)
        var m_ObjectCollider = GetComponent<SphereCollider>();
        //Here the GameObject's Collider is not a trigger
        m_ObjectCollider.isTrigger = false;
        //decide if the ball will move left or right on the x axis
        left_right = (Random.Range(0.0f,1.0f) < 0.5 ? -1 : 1);
    }


   private void Update() {
       //change object position
       Vector3 oldPosition = this.transform.position;
       Debug.Log(oldPosition[0]);
       this.transform.position = new Vector3(oldPosition[0] + left_right*Time.deltaTime*velocity, oldPosition[1] , oldPosition[2]);
   }


    private void OnTriggerEnter(Collider other) {
       Debug.Log("Change color of object collided with us"); 
       Material new_material = new Material(thisRenderer.material);
       Color new_color = getRandomColor(); 
       new_material.SetColor("_Color",  new_color);
       thisRenderer.material = new_material;
      
    }


    private Color getRandomColor(){
       Color randomColor = new Color(Random.Range(0.0f,1.0f),
                                    Random.Range(0.0f,1.0f),
                                    Random.Range(0.0f,1.0f));
        return randomColor;
   }

   public Vector3 getStartPosition(){
      return startPosition;
   }
    
}
