using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class smartphone : MonoBehaviour
{
    //핸드폰에는 문제를위한 정보말고도 다양한조작을할수있습니다.
    //문자메세지, 전화하기 버튼을누르면 상응하는 화면을 띄어줍니다.
    public RawImage quiz;
    public RawImage message;
    public RawImage answer;
    public Image a;
    public Text b;
    public Button k;

    void Awake()
    {
        Application.targetFrameRate = 40;


    }
    // Start is called before the first frame update
    void Start()
    {
        quiz.enabled = false;
        message.enabled = false;
        if (answer)
        {
            answer.enabled = false;
        }
        if (a)
        {
            a.enabled = false;
            b.enabled = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void click_message()
    {
        quiz.enabled = false;
        message.enabled = true;
        if (answer)
        {
            answer.enabled = true;
        }
        a.enabled = true;
        b.enabled = true;
        SoundManager.instance.PlayClickSound();

    }
    public void click_quiz()
    {
        quiz.enabled = true;
        message.enabled = false;
        if (answer)
        {
            answer.enabled = false;
        }
        a.enabled = false;
        b.enabled = false;
        SoundManager.instance.PlayClickSound();

    }
    public void click_answer()
    {
        quiz.enabled = false;
        if (answer)
        {
            answer.enabled = true;
        }
        SoundManager.instance.PlayClickSound();
    }


}
