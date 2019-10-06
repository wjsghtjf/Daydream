using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class mainview : MonoBehaviour
{
    public GameObject P;
    public GameObject player;
    public Camera myCamera;
    Vector3 OriginalRotation; 
    
    Vector3 cameraDist;
    int up = 0;
    bool U = false;
    bool D = false;
    Vector3 character_pos;
    void Awake()
    {
        Application.targetFrameRate = 40;


    }

    // Start is called before the first frame update
    void Start()
    {
        down_button();
        cameraDist = myCamera.transform.position - player.transform.position;
        OriginalRotation = new Vector3(myCamera.transform.localEulerAngles.x, myCamera.transform.localEulerAngles.y, myCamera.transform.localEulerAngles.z);
    }

    // Update is called once per frame
    void Update()
    {
      


 
        P.transform.position = player.transform.position + cameraDist;
    }
    public void up_button()
    {
       
        if (up < 1)
        {
            Vector3 newRotation = new Vector3(20f, 0f, 0f);
            myCamera.transform.localEulerAngles = myCamera.transform.localEulerAngles - newRotation;
            
                up ++;
            
        }

        
    }
    public void down_button()
    {
    
        if (up > -1)
        {
            Vector3 newRotation = new Vector3(-20f, 0f, 0f);
            myCamera.transform.localEulerAngles = myCamera.transform.localEulerAngles - newRotation;

            up--;
        }


    }


}



