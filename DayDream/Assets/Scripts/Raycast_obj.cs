using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycast_obj : MonoBehaviour
{
    private GameObject target;
    int Quiz_Check=0;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(Quiz_Check);
        if (Input.GetMouseButtonDown(0))
        {

            if (Quiz_Check == 0)
            {
                target = GetClickedObject();
            }
            if (target)
            {
                if (target.tag == "Quiz_Object"||target.tag=="private_lock")  //선택된게 나라면
                {
                    if (target.tag != "NoRay")
                    {
                        hint_picture show = target.GetComponent<hint_picture>();
                        if(show.check==false &&Quiz_Check==0)
                        {
                            show.check = true;
                            Quiz_Check = 1;
                        }
                        if ((show.check == false && Quiz_Check == 1))
                        {

                            Quiz_Check = 0;
                        }





                    }
                    //target.transform.position = new Vector3(4f, 0f, -2f);
                  
                    //여기에다가 코드 작성 하시면 됩니다. 
                }
            }
            else
            {
                Quiz_Check = 0;
            }
        }
    }
        private GameObject GetClickedObject()
        {
                RaycastHit hit;
                GameObject target = null;
                    
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition); //마우스 포인트 근처 좌표를 만든다. 
        int layerMask = 1 << LayerMask.NameToLayer("Quiz");
        if (true == (Physics.Raycast(ray.origin, ray.direction * 10, out hit,1f,layerMask)))   //마우스 근처에 오브젝트가 있는지 확인
            {

            if (hit.transform.parent&& hit.transform.parent.tag!="Map_item_quiz")
            {
                target = hit.transform.parent.gameObject;
            }
            else
            {
                //있으면 오브젝트를 저장한다.
                target = hit.collider.gameObject;
            }
           
        }

        Debug.Log(target);
        return target;
        }
   
}
