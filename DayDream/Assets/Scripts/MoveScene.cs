using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MoveScene : MonoBehaviour
{ //간단히 씬이동합니다

    float t = 0f;
    void Update()
    {
        t += Time.deltaTime;

        if (SceneManager.GetActiveScene().name == "movie")
        {
            if(t>=15.5f)
            {
                SceneManager.LoadScene("explain");
            }
        }
    }




   public void GoToGame()
    {
        SceneManager.LoadScene("Stage1");
        Debug.Log("game");
    }
    public void GoToExplain()
    {
        SceneManager.LoadScene("explain");
        Debug.Log("game");
    }

    public void GoToTutorial()
    {
        SceneManager.LoadScene("tutorial");
    }

    public void GoToEnding()
    {
        SceneManager.LoadScene("ending");
    }

    public void GoToFirst()
    {
        SceneManager.LoadScene("start_scene");
    }

}
