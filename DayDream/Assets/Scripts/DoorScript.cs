using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DoorScript : MonoBehaviour
{
    //문의 움직임을 다루는 script입니다. 저흰 chest, door의 움직임을 script를 통하여 구현하였습니다.
    //lock은 특정조건,혹은 특정문제를 풀렸을때 false로 바뀝니다. lock 이 true로 되어있으면 플레이어가다가와도 문이열리지않습니다.
    //lock 이 해제되고, 플레이어가 다가오면 문이열립니다.
    public bool locked = false;
    public bool open = false;
    public float doorOpenAngle = -90f;
    public float doorCloseAngle = 0f;
    public float smoot = 2f;

    public void ChangeDoorState() { open = !open; }

    
    
    void Start()
    {
        
    }

    
    void OnTriggerStay(Collider other)
    {

        if (other.tag == "Player")
        {
            if (locked == false)
            {
                open = true;
            }

        }
    }

    void OnTriggerExit(Collider other)
    {

        if (other.tag == "Player")
        {
            open = false;


        }
    }


    void Update()
    {
        if (open)
        {
            Quaternion targetRotation = Quaternion.Euler(0, doorOpenAngle, 0);
            transform.localRotation = Quaternion.Slerp(transform.localRotation, targetRotation, smoot * Time.deltaTime);
        }
        else
        {
            Quaternion targetRotation2 = Quaternion.Euler(0, doorCloseAngle, 0);
            transform.localRotation = Quaternion.Slerp(transform.localRotation, targetRotation2, smoot * Time.deltaTime);
        }
    }

    
        
    
}
