using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    //게임의 사운드를 담당합니다
    // Start is called before the first frame update
    public AudioClip sound_back1;
    public AudioSource back1Audio;
    public AudioClip sound_back2;
    public AudioSource back2Audio;

    public AudioClip sound_complete;
    public AudioSource CompleteAudio;
    public AudioClip sound_door;
    public AudioSource DoorAudio;
    public AudioClip sound_right;
    public AudioClip sound_wrong;
    public AudioClip sound_button;
    public AudioClip sound_keyboard;
    public AudioClip sound_enddoor;
    public AudioClip sound_click;
    public AudioSource clickAudio;
    public AudioSource rightAudio;
    public AudioSource wrongAudio;
    public AudioSource buttonAudio;
    public AudioSource keyboardAudio;
    public AudioSource endDoorAudio;
    public static SoundManager instance;
    public bool k;
    void Awake()
    {
        if(SoundManager.instance==null)
        {
            SoundManager.instance = this;

        }
    }
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        if (k == false)
        {
            if (back1Audio.isPlaying == false)
            {
                back1Audio.Play();
            }
        }
        else
        {
            Debug.Log("okay");
            // back1Audio.Stop();
            back1Audio.clip = sound_back2;

            // back2Audio.Play();
            if (back1Audio.isPlaying == false)
            {
                back1Audio.Play();
            }

        }


        
    }
    public void PlayCompleteSound()
    {
        CompleteAudio.PlayOneShot(sound_complete);
    }



    public void PlayClickSound()
    {
        clickAudio.PlayOneShot(sound_click);
    }

    public void PlayDoorSound()
    {
       DoorAudio.PlayOneShot(sound_door);
    }

    public void PlayKeyboardSound()
    {
        keyboardAudio.PlayOneShot(sound_keyboard);
    }
    public void PlayButtonSound()
    {
        buttonAudio.PlayOneShot(sound_button);
    }
    public void PlayWrongSound()
    {
        wrongAudio.PlayOneShot(sound_wrong);
    }
    public void PlayRightSound()
    {
        rightAudio.PlayOneShot(sound_right);
    }
    public void PlayEndSound()
    {
        
        endDoorAudio.PlayOneShot(sound_enddoor,0.3f);
    }
}
