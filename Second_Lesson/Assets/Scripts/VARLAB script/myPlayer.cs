using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum InputMode
{
    NONE,
    TELEPORT,
    CHOOSE_PIC,
    EXPLORE,
}


public class myPlayer : MonoBehaviour
{
    public static myPlayer instance;
    public InputMode activeMode;

    void Awake()
    {
        if (instance != null)
        {
            GameObject.Destroy(instance.gameObject);
        }
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        this.activeMode = InputMode.TELEPORT;
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(this.activeMode);
    }
}
