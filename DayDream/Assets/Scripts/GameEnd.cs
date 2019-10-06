using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEnd : MonoBehaviour
{
    //게임이 끝날경우,stagemanager의 score을 1올려줍니다. 이는 스테이지 1을 클리어했다는 의미로 후에 사용됩니다
    public GameObject End;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        

    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag=="Player")
        {
            StageManager Clear = End.GetComponent<StageManager>();
            if (Clear.time > 0)
            {
                Clear.score = 1; //clear
            }

        }
    }

}
