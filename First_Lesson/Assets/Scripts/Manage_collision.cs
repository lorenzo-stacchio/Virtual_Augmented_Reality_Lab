using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manage_collision : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Fetch the GameObject's Collider (make sure they have a Collider component)
        var m_ObjectCollider = GetComponent<BoxCollider>();
        //Here the GameObject's Collider is not a trigger
        m_ObjectCollider.isTrigger = false;
        //Output whether the Collider is a trigger type Collider or not
        Debug.Log("Trigger On : " + m_ObjectCollider.isTrigger);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
