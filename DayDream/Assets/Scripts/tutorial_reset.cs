using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tutorial_reset : MonoBehaviour
{
    //tutorial 영상 canvas reset
    public Canvas a;
    public Canvas b;
    public Canvas c;
    public Canvas d;
    public Canvas e;
    public Canvas f;
    public Canvas g;
    

    // Start is called before the first frame update
    void Start()
    {
        a.enabled = false;
        b.enabled = false;
        c.enabled = false;
        d.enabled = false;
        e.enabled = false;
        f.enabled = false;
        g.enabled = false;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
