using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Option : MonoBehaviour
{
    public Canvas Opt;
    public Text t;
    int tim;
    public GameObject manager;
    public Slider slide;
    public Slider slide_H;
    public GameObject Player;
    public bool OnOff = false;
    // Start is called before the first frame update
    void Start()
    {
        Opt.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        StageManager count = manager.GetComponent<StageManager>();
        SimpleCharacterControl move = Player.GetComponent<SimpleCharacterControl>();
       move.plusV = slide.value;
       move.plusH = slide_H.value;
     
        if (OnOff == true) { 
        count.time += Time.deltaTime;
        tim = Mathf.FloorToInt(count.time); ;
        t.text = "Time: "+tim.ToString();
        }


    }
    public void Opt_On()
    {
        Opt.enabled = true;
        OnOff = true;
       
    }
    public void Opt_Off()
    {
        Opt.enabled = false;
        OnOff = false;
    }
    public void Move_reset()
    {
        slide.value = 1f;
        slide_H.value = 1f;
    }


}
