using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Start_game : MonoBehaviour
{
    //clear 했으면 다음스테이지를보여줍니다. 다만 스테이지2는 추후개발예정입니다
    public Canvas Stage2;
    public GameObject clear;
    public Canvas StartPage;
    public Canvas RogoPage;

    void Start()
    {
        Stage2.enabled = false;
        StartPage.enabled = false;
        RogoPage.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        StageManager Clear = clear.GetComponent<StageManager>();
        if (Clear.score==1)
        {
            Stage2.enabled = true;
        }
        else
        {
            Stage2.enabled = false;
        }

        
    }

    public void begin()
    {
        StartPage.enabled = true;
        RogoPage.enabled = false;
    }
}
