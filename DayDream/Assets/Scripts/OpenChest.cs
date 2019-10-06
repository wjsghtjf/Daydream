using UnityEngine;
using System.Collections;

public class OpenChest : MonoBehaviour {

    //퍼블리싱 왜 안돼요?
    //script를통해 chest를 open하고 문제를보여줍니다
    [Range(0.0f, 1.0f)]
    public float factor;
    public GameObject player;
    public GameObject End;
    Quaternion closedAngle;
    Quaternion openedAngle;
    public Camera cam;
    public Canvas chest_hint;
    public Canvas chest_close_hint;
    int checkTime;
    int checkTime2;
    public bool closing;
    public bool opening;
    int IsOpen = 0;
    int IsOpen2 = 0;
    public float speed = 0.5f;

    int newAngle = 127;

    // Use this for initialization
    void Close()
    {
        closing = true;
        opening = false;
    }

    void Open()
    {
        opening = true;
        closing = false;
    }

    void Start () {
       
        chest_hint.enabled = false;
        chest_close_hint.enabled = false;
        Close();
        openedAngle = transform.rotation;
        closedAngle = Quaternion.Euler(transform.eulerAngles + Vector3.right * newAngle);
        checkTime = 5;
        checkTime2 = 5;
    }
	
	// Update is called once per frame
	void Update () {

        if (closing)
        {
            factor += speed * Time.deltaTime;

            if (factor > 1.0f)
            {
                factor = 1.0f;
            }
        }
        if (opening)
        {
            factor -= speed * Time.deltaTime;

            if (factor < 0.0f)
            {
                factor = 0.0f;
            }
        }

        transform.rotation = Quaternion.Lerp(openedAngle, closedAngle, factor);

        SimpleCharacterControl Count = player.GetComponent<SimpleCharacterControl>();
        /*if (Count.deadface > 0) {
            Open();
            Count.deadface = 0;
            IsOpen2 = 1;
            //chest_hint.enabled = true;
        }*/




    }

    //You probably want to call this somewhere
   

    private void OnTriggerStay(Collider other)
    {

        SimpleCharacterControl Count = player.GetComponent<SimpleCharacterControl>();
        
        if ((other.tag == "Player" && Count.i_key_count > 0) || (other.tag == "Player" && IsOpen==1) )
        {

            if (IsOpen2 == 0)
            {
                IsOpen = 1;
                Open();
                Count.i_key_count--;
                Count.chest_quiz++;
                MoveScene eee = cam.GetComponent<MoveScene>();
                eee.GoToEnding();
                StageManager Clear = End.GetComponent<StageManager>();
                if (Clear.time > 0)
                {
                    Clear.score = 1; //clear
                }
            }
           
        }
        else if (other.tag == "Player" && Count.i_key_count <= 0)
        {

            chest_close_hint.enabled = true;
        }


    }
    
    void OnTriggerExit(Collider other)
    {

        if (other.tag == "Player")
        {
            
            chest_hint.enabled = false;
            chest_close_hint.enabled = false;

        }
    }
    



}
