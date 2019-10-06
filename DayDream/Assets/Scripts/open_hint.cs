using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class open_hint : MonoBehaviour
{
    // Start is called before the first frame update
    public RawImage HinT;
    public Button hint1;
    public Button hint2;
    public Button hint3;
    public Button hint4;
    public Text txt1;
    public Text txt2;
    public Text txt3;
    public Text txt4;
    public bool check = false;
    public int cor = 0;
    public bool IsOpen=false;

    void Start()
    {
        hint1.enabled = false;
        hint2.enabled = false;
        hint3.enabled = false;
        hint4.enabled = false;
        //txt1.enabled = false;
        txt2.enabled = false;
        txt3.enabled = false;
        txt4.enabled = false;
        HinT.enabled = false;


    }

    // Update is called once per frame
    void Update()
    {
        if(cor==1)
        {
            if (check) {
                HinT.enabled = true;
            hint1.enabled = true;
                hint2.enabled = true;
                hint3.enabled = true;
                hint4.enabled = true;
               // txt1.enabled = true;
                txt2.enabled = true;
                txt3.enabled = true;
                txt4.enabled = true;
            }
           /* else
            {
                HinT.enabled = false;
                hint1.enabled = false;
                hint2.enabled = false;
                hint3.enabled = false;
                hint4.enabled = false;
                txt1.enabled = false;
                txt2.enabled = false;
                txt3.enabled = false;
                txt4.enabled = false;
            }*/
        }
      
        
    }

    public void hint()
    {
        if (check == false)
        {
            check = true;
        }
        else
        {
            check = false;
        }
    }


}
