using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class close_up : MonoBehaviour
{
    //show detail-> close_up 에는 쇼디테일 넣고, hint 에는 close 넣기


    // Start is called before the first frame update
    public Canvas me;
    public Canvas picture;
    public GameObject obj;
  
    public bool check = false;
    public bool check_me = true;
    int a = 0;
    
    public int OnOff;

    void Start()
    {
        picture.enabled = false;
        me.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {

            if (check == false)
            {
               // Debug.Log("bb");
                picture.enabled = false;
            }
            else if(check==true)
            {
                Debug.Log("ht");
                picture.enabled = true;
            }
       
        
     

       /* if(me.enabled==false)
        {
            picture.enabled = false;
            me.enabled = false;
        }*/



    }

    public void close()
    {
       
        // hint_picture Count = obj.GetComponent<hint_picture>();
        // Count.show_detail();
        open_hint Count = GameObject.FindWithTag("pc_hint").GetComponent<open_hint>();
        Count.cor = 1;
        /*if (a == 0)
        {
            a = 1;
            Debug.Log(a);
        }
        else
        {*/
            if (check == false)
            {
                Count.check = true;
                check = true;
            }
            else
            {
                Count.check = false;
                check = false;
            }
       // }
    }
   

}
