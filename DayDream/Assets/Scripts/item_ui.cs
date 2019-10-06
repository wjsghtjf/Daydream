using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class item_ui : MonoBehaviour
{
    public GameObject player;
    public RawImage key;
    //아이템을 먹었을떄, 먹은아이템이 아이템 ui에 뜹니다. stage1 에서는 아이템이 key 밖에 사용되지않았습니다.
    void Start()
    {
        key.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        SimpleCharacterControl Count = player.GetComponent<SimpleCharacterControl>();
        if (Count.i_key_count>0)
        {
            key.enabled = true;
        }
        else
        {
            key.enabled = false;
        }


    }
}
