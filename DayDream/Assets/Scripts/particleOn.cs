using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class particleOn : MonoBehaviour
{
    public ParticleSystem partic;
    // Start is called before the first frame update
    void Start()
    {
        partic.enableEmission = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerStay(Collider other)
    {
        if ( other.tag == "Player")
        {
            partic.enableEmission = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.tag=="Player")
        {
            partic.enableEmission = false;
        }

    }


}
