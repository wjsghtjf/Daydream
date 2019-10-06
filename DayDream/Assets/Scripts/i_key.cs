using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class i_key : MonoBehaviour
{ //아이템을 먹었을때 힌트를 나오게 하고 인벤토리에 추가합니다.
    
    public GameObject player;
    public GameObject gameObject1;
    int once = 0;
    public Canvas hint; // item를 먹었을떄의 힌트
  
    
   
    int checkTime;  // 특정 시간을 갖는 변수

    void Start()
    {
        hint.enabled = false;

        checkTime = 5;
    }

    // Update is called once per frame
    void Update()
    {
        if (checkTime != 5)
        {
            if (Time.time - checkTime <= 3)
            {
                hint.enabled = true;
            }
            else
            {
                hint.enabled = false;
            }
        }


    }
    private void OnTriggerEnter(Collider other)
    {
        if ((other.tag == "Player"&& gameObject1.tag== "key")&&once==0)
        {
            once = 1;
            Debug.Log("hit");
            SimpleCharacterControl Count = player.GetComponent<SimpleCharacterControl>();
            Count.i_key_count++;
            checkTime = (int)Time.time;
            gameObject1.transform.position = new Vector3(0, 0, -20f);
            gameObject1.GetComponent<Renderer>().enabled = false;


            Destroy(gameObject1,5);


        }

       

    }
}
