using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class move_can : MonoBehaviour
{
    public GameObject obj;
    public Canvas me;
    public Canvas next;
    public Canvas next2;
    public Canvas next3;
    // Start is called before the first frame update
    void Start()
    {
        me.enabled = false;
        if (next)
        {
            next.enabled = false;
        }
        if (next2)
        {
            next2.enabled = false;
        }
        if (next3)
        {
            next3.enabled = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    

    public void move1()
    {
        
        if (me.tag=="pc_park")
        {

            hint_picture Count = obj.GetComponent<hint_picture>();
            Count.check = false;
        }
        if (next.tag == "pc_park")
        {
            hint_picture Count = obj.GetComponent<hint_picture>();
            Count.check = true;
        }
        if(obj)
        {
            if(obj.tag== "pc_park")
            {
                SoundManager.instance.PlayClickSound();
            }
        }


        me.enabled = false;
        if (next)
        {
            next.enabled = true;
        }
    }
    public void move2()
    {
        SoundManager.instance.PlayClickSound();
        if (me.tag == "pc_park")
        {
            hint_picture Count = obj.GetComponent<hint_picture>();
            Count.check = false;
        }
        if (next2.tag == "pc_park")
        {
            hint_picture Count = obj.GetComponent<hint_picture>();
            Count.check = true;
        }
        me.enabled = false;
        next2.enabled = true;
    }
    public void move3()
    {
        SoundManager.instance.PlayClickSound();
        if (me.tag == "pc_park")
        {
            hint_picture Count = obj.GetComponent<hint_picture>();
            Count.check = false;
        }
        if (next3.tag == "pc_park")
        {
            hint_picture Count = obj.GetComponent<hint_picture>();
            Count.check = true;
        }
        me.enabled = false;
        next3.enabled = true;
    }

    public void move_first()
    {
        
        me.enabled = false;
        if (next)
        {
            next.enabled = false;
        }
        if (next2)
        {
            next2.enabled = false;
        }
    }

}
