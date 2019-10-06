using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class tutorial : MonoBehaviour
{
    public Canvas first;
        public Canvas one;
        public Canvas Next;
    public Canvas kill;
  
    // Start is called before the first frame update
    void Start()
    {   if (one)
        {
            one.enabled = false;
        }
        if (Next)
        {
            Next.enabled = false;
        }
       
        
    }

    // Update is called once per frame
    void Update()
    {
        
     

    
    }

public void click1() {
        if(first)
        {
            first.enabled = false;
        }

        if (one)
        {
            one.enabled = false;
        }
        if (Next)
        {
            Next.enabled = true;
        }
        if (kill )
        {
            kill.enabled = false;
        }



    }
    public void click2()
    {
        SceneManager.LoadScene("movie");

        if (one)
        {
            one.enabled = false;
        }
        if (Next)
        {
            Next.enabled = true;
        }
        if (kill)
        {
            kill.enabled = false;
        }
    }
    public void click3()
    {
        SceneManager.LoadScene("movie");

        if (one)
        {
            one.enabled = false;
        }
        if (Next)
        {
            Next.enabled = true;
        }
        if (kill)
        {
            kill.enabled = false;
        }
    }

    public void click_skip()
    {
        SceneManager.LoadScene("movie");

    }

    public void click_gotogame()
    {
        SceneManager.LoadScene("Stage1");
    }
}


