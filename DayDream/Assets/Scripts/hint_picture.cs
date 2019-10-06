using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hint_picture : MonoBehaviour
{
    public Canvas picture_hint;
    public Canvas detail;
    public Image hint;
    public Text hintt;
    int c=0;
    int checkTime = 5;
    public bool check = false;
   
    void Start()
    {
        //핵심1번입니다. 각문제의 진입점 역할을하는 스크립트입니다.
        //저희의 게임은 자세히보기(show_detail)를 눌러야 ui를 보여주는데 그부분을 담당합니다. check를 true,false로 바꾸며 이를 진행합니다
        //힌트를사용하면 제한시간 60초 차감됩니다
        picture_hint.enabled = false;
        if (detail)
        {
            detail.enabled = false;
        }

        if (hint)
        {
            hint.enabled = false;
            hintt.enabled = false;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
  
    public void show_detail()
    {
        
        if(picture_hint.enabled==false)
        {
            picture_hint.enabled = true;
        }
        else
        {
            picture_hint.enabled = false;
        }

    }

    public void background_back()
    {
        picture_hint.enabled = false;
    }

    public void show_hint()
    {
        StageManager ttt = GameObject.FindWithTag("gm").GetComponent<StageManager>();
        open_hint Count = GameObject.FindWithTag("pc_hint").GetComponent<open_hint>();
        if (hint)
        {
            if (hint.enabled == true)
            {
                hint.enabled = false;
                hintt.enabled = false;
                

            }
            else if (hint.enabled == false)
            {
              
                ttt.time -= 60f;
                hint.enabled = true;
                hintt.enabled = true;

            }
        

        }


    }


    private void OnTriggerStay(Collider other)
    {
        if (detail&& other.tag == "Player")
        {
            detail.enabled = true;
        }
        if (other.tag == "Player" && check)
        {
           // picture_hint.enabled = true;
        }
        if (other.tag == "Player" && !check)
        {
          //  picture_hint.enabled = false;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            picture_hint.enabled = false;
            detail.enabled = false;
        }
    }


}