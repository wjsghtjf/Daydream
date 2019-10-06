using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class fade : MonoBehaviour
{
    //튜토리얼에서 fadein을 담당하는 스크립트입니다.
    float fades = 1.0f;
    float time = 0f;
    public Image fadde;
    public Canvas can;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (can.enabled == true)
        {
            time += Time.deltaTime;
            if (fades > 0f && time >= 0.1f)
            {
                fades -= 0.2f;
                fadde.color = new Color(0, 0, 0, fades);
                time = 0;
            }
            else if (fades <= 0.0f)
            {
                time = 0;
                Destroy(fadde);
            }
        }
    }
}
