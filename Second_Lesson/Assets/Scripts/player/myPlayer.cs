using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum InputMode
{
    NONE,
    TELEPORT,
    COLLECT
}


public class myPlayer : MonoBehaviour
{
    public static myPlayer instance;
    public InputMode activeMode;
    public int mushrooms_collected;  


    void Awake()
    {
        if (instance != null)
        {
            GameObject.Destroy(instance.gameObject);
        }
        instance = this;
        this.mushrooms_collected = 0;  
    }


    // Start is called before the first frame update
    void Start()
    {
        this.activeMode = InputMode.NONE;
    }


    // Update is called once per frame
    void Update()
    {
        //Debug.Log("user" + this.activeMode.ToString());
    }


    public void collect_mushroom(){
        this.mushrooms_collected +=1;
        //Debug.Log("NUMERO FUNGHI");
        //Debug.Log(this.mushrooms_collected);
    } 

    public int collected_mushrooms(){
        return this.mushrooms_collected;
    }


}
