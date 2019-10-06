
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class num_lock : MonoBehaviour
{

   //핵심 코드2
    //모든 버튼클릭문제를 해결합니다.
    //각 문제의 답이 update에 있는 정답과 일치하면 해당 action을 합니다.
    // 문제의 답들이 꼬이지않도록 tag를통해 구분을해둡니다. ex) 금고문제답 357 과 교수님 비밀번호 1357 답은 , 해당문제에서만 정답이됩니다.
    public static float time;
    public Camera cam;
    //public GameObject door;
    public Text uiText;
    public RawImage password;
    public RawImage open;
    public RawImage lighton;
    public GameObject pass;
    public GameObject onlyfor_pro_Comp;
    public int Reset_but = 0;
    int R = 0;
    int G = 0;
    int B = 0;
    int RGB = 0;
    /// <summary>
  //이부분은 각문제의 정답체크부분. 각 알파벳이 1이아니게되면 정답처리된것.

    int a = 1;
    int b = 1;
    int c = 1;
    int d = 1;
    int e = 1;
    int f = 1;
    int r = 1;
    /// </summary>
     int but = 0;
    Text RT;
    Text GT;
    Text BT;
    int pro_Q = 0;
    public int switch_on = -1;
    

    public string ans;
    // Start is called before the first frame update
    void Awake()
    {
        Application.targetFrameRate = 40;

       
    }

    void Start()
    {
        if (password)
        {
            password.enabled = true;
        }
        if (open)
        {
            open.enabled = false;
        }

        if(onlyfor_pro_Comp)
        {
            if(onlyfor_pro_Comp.tag=="psss")
            {
                onlyfor_pro_Comp.SetActive(false);
            }
        }
        StageManager ttt = GameObject.FindWithTag("gm").GetComponent<StageManager>();

    }

    // Update is called once per frame
    void Update()
    {
        if (but >= 1)
        {
            if(switch_on==-1)
            {
                but = 0;
            }

            if (pass.tag == "switch")
            {
                if (switch_on == 0)
                {
                    Debug.Log(switch_on);
                    if (open)
                    {
                        open.enabled = true;
                        GameObject Count = GameObject.FindWithTag("destroy");
                        GameObject Count2 = GameObject.FindWithTag("destroy2");
                        GameObject lig = GameObject.FindWithTag("light");
                        Destroy(Count);
                        Destroy(Count2);
                        Destroy(lig);
                    }
                    if (password)
                    {
                        password.enabled = false;
                    }



                    if (onlyfor_pro_Comp && switch_on == 0)
                    {
                        onlyfor_pro_Comp.SetActive(true);
                        switch_on = 1;
                        lighton.enabled = false;
                       
                    }
                }
            }
            if(pass.tag=="fuseBox")
            {
                if (open)
                {
                    open.enabled = true;
                }
                if (password)
                {
                    password.enabled = false;
                }
                if (onlyfor_pro_Comp && switch_on == -1)
                {
                    num_lock Count = onlyfor_pro_Comp.GetComponent<num_lock>();
                    Count.switch_on = 0;
                   
                   
                }


            }


        }


        if (ans == "1357")
        {
            if (pass)
            {
                if (pass.tag == "professor_comp")
                {
                    if (open)
                    {
                        open.enabled = true;
                    }
                    if (password)
                    {
                        password.enabled = false;
                    }
                  
                        Destroy(pass);
                    
                    if (onlyfor_pro_Comp)
                    {
                        Destroy(onlyfor_pro_Comp);
                    }
                    if (b == 1)
                    {
                        SoundManager.instance.PlayCompleteSound();
                        b = 2;
                    }
                }
            }
        }

        if (ans == "357")
        {
            if (pass)
            {
                if (pass.tag == "private_lock")
                {
                    GameObject C = GameObject.FindWithTag("Player");
                    if (onlyfor_pro_Comp)
                    {
                        onlyfor_pro_Comp.transform.position = C.transform.position;
                    }

                    hint_picture Count = pass.GetComponent<hint_picture>();
                    Count.picture_hint.enabled = false;
                    Count.detail.enabled = false;
                    Count.picture_hint.enabled = false;
                    Destroy(pass);

                    if (d == 1)
                    {
                        SoundManager.instance.PlayCompleteSound();
                        d = 3;
                    }
                }
            }


        }
        if (ans == "38")
        {

            if (pass.tag == "door")
            {
                GameObject Cube = GameObject.FindWithTag("cube");
                Destroy(Cube);
                hint_picture Count2 = onlyfor_pro_Comp.GetComponent<hint_picture>();
                Count2.picture_hint.enabled = false;


                DoorScript Count = pass.GetComponent<DoorScript>();
                Count.locked = false;
                Count.open = true;
                if (a == 1)
                {
                    SoundManager.instance.PlayDoorSound();
                    a = 2;
                }
                ///
                SoundManager c = cam.GetComponent<SoundManager>();
                c.k = true;

            }
            ////

        }

        if (but == 8)
        {
            if (pass.tag=="button_click")
            {
                hint_picture Count = pass.GetComponent<hint_picture>();
                Count.picture_hint.enabled = false;
                Count.detail.enabled = false;
                Destroy(pass);
            }
            if (onlyfor_pro_Comp)
            {
                onlyfor_pro_Comp.transform.position = new Vector3(4f, 0f, -2f);
            }
            if (c == 1)
            {
                SoundManager.instance.PlayCompleteSound();
                c = 2;
            }

        }
        if (RGB == 17)
        {
            if (R == 3 && G == 5 && B == 9)
            {
                if (pass)
                {
                    SoundManager.instance.PlayEndSound();
                    Destroy(pass);
                }
               
            }
            else
            {
                R = 0;
                G = 0;
                B = 0;
            }

        }

        if (ans == "DEADFACE")
        {
            SimpleCharacterControl Count = GameObject.FindWithTag("Player").GetComponent<SimpleCharacterControl>();
            Count.deadface++;

            if (open)
            {
                open.enabled = true;
            }
            if (password)
            {
                password.enabled = false;
            }
            pass.GetComponent<Renderer>().enabled = true;
            onlyfor_pro_Comp.GetComponent<Renderer>().enabled = true;

            if (e == 1)
            {
                SoundManager.instance.PlayCompleteSound();
                e = 3;
            }
            if(f == 1)
            { SoundManager.instance.PlayButtonSound();
                f = 9;
            }
        }

        if (ans == "LAICEPS")
        {
            GameObject Cube = GameObject.FindWithTag("ddd");
            Destroy(Cube);
            if (pass.tag == "pc_hint")
            {
                onlyfor_pro_Comp.SetActive(true);
                //open_hint Count = pass.GetComponent<open_hint>();
                // Count.cor = 1;
                if (open)
                {
                    open.enabled = true;
                }
                if (password)
                {
                    password.enabled = false;
                    
                }
               
            }
        }

        if (ans == "MCCCCXCII")
        {
            if (pass.tag == "pc_park")
            {
                //open_hint Count = pass.GetComponent<open_hint>();
                // Count.cor = 1;
                if (open)
                {
                    open.enabled = true;                 
                }
                if (password)
                {
                    password.enabled = false;
                }
                
            }
            

        }






    }
    public void click_Button()
    {
        but += 1;
        if (uiText)
        {
            uiText.text += "▶";
            SoundManager.instance.PlayRightSound();
        }
        else
        {
            SoundManager.instance.PlayButtonSound();
        }
        Reset_but = 0;
        

    }
    public void click_but_reset()
    {
        but = 0;
        uiText.text = "progress : ";

        Reset_but = 1;
        SoundManager.instance.PlayWrongSound();


    }
    public void click_R()
    {
        R += 1;
        RGB += 1;
        uiText.text = R.ToString() + "                    " + G.ToString() + "                    " + B.ToString();
        SoundManager.instance.PlayKeyboardSound();
    }
    public void click_G()
    {
        G += 1;
        RGB += 1;
        uiText.text = R.ToString() + "                    " + G.ToString() + "                    " + B.ToString();
        SoundManager.instance.PlayKeyboardSound();
    }
    public void click_B()
    {
        B += 1;
        RGB += 1;
        uiText.text = R.ToString() + "                    " + G.ToString() + "                    " + B.ToString();
        SoundManager.instance.PlayKeyboardSound();
    }
    public void RGB_reset()
    {
        R = 0;
        G = 0;
        B = 0;
        RGB = 0;
        uiText.text = "0" + "                    " + "0" + "                    " + "0";
        SoundManager.instance.PlayKeyboardSound();
    }
    public void click_1()
    {
        int t = 1;
        ans += t.ToString();
        uiText.text += t.ToString();
        SoundManager.instance.PlayKeyboardSound();
    }
    public void click_2()
    {
        int t = 2;
        ans += t.ToString();
        uiText.text += t.ToString();
        SoundManager.instance.PlayKeyboardSound();
    }
    public void click_3()
    {

        int t = 3;
        ans += t.ToString();
        uiText.text += t.ToString();
        SoundManager.instance.PlayKeyboardSound();
    }
    public void click_4()
    {

        int t = 4;
        ans += t.ToString();
        uiText.text += t.ToString();
        SoundManager.instance.PlayKeyboardSound();
    }
    public void click_5()
    {

        int t = 5;
        ans += t.ToString();
        uiText.text += t.ToString();
        SoundManager.instance.PlayKeyboardSound();
    }
    public void click_6()
    {

        int t = 6;
        ans += t.ToString();
        uiText.text += t.ToString();
        SoundManager.instance.PlayKeyboardSound();
    }
    public void click_7()
    {
        int t = 7;
        ans += t.ToString();
        uiText.text += t.ToString();
        SoundManager.instance.PlayKeyboardSound();
    }
    public void click_8()
    {
        int t = 8;
        ans += t.ToString();
        uiText.text += t.ToString();
        SoundManager.instance.PlayKeyboardSound();
    }
    public void click_9()
    {
        int t = 9;
        ans += t.ToString();
        uiText.text += t.ToString();
        SoundManager.instance.PlayKeyboardSound();
    }
    public void click_0()
    {
        int t = 0;
        ans += t.ToString();
        uiText.text += t.ToString();
        SoundManager.instance.PlayKeyboardSound();
    }
    public void wrong()
    {
        ans = "";
        uiText.text = "";
        SoundManager.instance.PlayKeyboardSound();
    }

    public void click_a()
    {
        ans += "A";
        uiText.text += "A";
        SoundManager.instance.PlayKeyboardSound();
    }
    public void click_b()
    {
        ans += "B";
        uiText.text += "B";
        SoundManager.instance.PlayKeyboardSound();
    }
    public void click_c()
    {
        ans += "C";
        uiText.text += "C";
        SoundManager.instance.PlayKeyboardSound();
    }
    public void click_d()
    {
        ans += "D";
        uiText.text += "D";
        SoundManager.instance.PlayKeyboardSound();
    }
    public void click_e()
    {
        ans += "E";
        uiText.text += "E";
        SoundManager.instance.PlayKeyboardSound();
    }
    public void click_f()
    {
        ans += "F";
        uiText.text += "F";
        SoundManager.instance.PlayKeyboardSound();
    }
    public void click_g()
    {
        ans += "G";
        uiText.text += "G";
        SoundManager.instance.PlayKeyboardSound();
    }
    public void click_s()
    {
        ans += "S";
        uiText.text += "S";
        SoundManager.instance.PlayKeyboardSound();
    }
    public void click_p()
    {
        ans += "P";
        uiText.text += "P";
        SoundManager.instance.PlayKeyboardSound();
    }
    public void click_i()
    {
        ans += "I";
        uiText.text += "I";
        SoundManager.instance.PlayKeyboardSound();
    }
    public void click_l()
    {
        ans += "L";
        uiText.text += "L";
        SoundManager.instance.PlayKeyboardSound();
    }

    public void click_m()
    {
        ans += "M";
        uiText.text += "M";
        SoundManager.instance.PlayKeyboardSound();
    }
    public void click_x()
    {
        ans += "X";
        uiText.text += "X";
        SoundManager.instance.PlayKeyboardSound();
    }



}
/// <summary>
/// /////////
/// </summary>
      

