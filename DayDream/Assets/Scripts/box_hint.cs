using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class box_hint : MonoBehaviour
{

  

    public Canvas box;
    // Start is called before the first frame update
    void Awake()
    {
        Application.targetFrameRate = 40;
    }

    void Start()
    {
        box.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerStay(Collider other)
    {
        if(other.tag=="Player")
        {
            box.enabled = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            box.enabled = false;
        }

    }

}
