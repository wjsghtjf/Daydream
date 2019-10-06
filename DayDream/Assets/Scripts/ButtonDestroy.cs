using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonDestroy : MonoBehaviour
{
    //문제중, 정답인 연두색,붉은색 버튼을 클릭하는 문제가있습니다.
    //한번 입력한 버튼은 다시눌렀을떄 작동이되지않아야하기에 작성된코드입니다. canvas_button_question의 정답 버튼들에 들어가있습니다.
   
    public RawImage computer;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        num_lock Count = computer.GetComponent<num_lock>();
        if (Count.Reset_but == 1)
        {
            GetComponent<Button>().interactable = true;
        }
    }
    public void Click()
    {
        GetComponent<Button>().interactable = false;
    }
}
