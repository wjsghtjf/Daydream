using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChildOff : MonoBehaviour
{
    public Button me;
    public RawImage me2;
    public RawImage parent;
    // Start is called before the first frame update
    void Start()
    {
        me.enabled = false;
        if (me2)
        {
            me2.enabled = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(parent.enabled==false)
        {
           me.enabled = false;
            if(me2)
            {
                me2.enabled = false;
            }
        }
        else if (parent.enabled == true)
        {
            me.enabled =true;
            if (me2)
            {
                me2.enabled = true;
            }
        }
    }
}
