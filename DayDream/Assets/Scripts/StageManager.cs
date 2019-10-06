using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class StageManager : MonoBehaviour
{
   /*게임의 스테이지 관련정보를 저장합니다.
    *(4번 가장중요)
   1.스테이지 시관관리.
   2. 게임이끝날때 게임오버인지,클리어인지보여주기
   3.씬 로드,
   4. 클리어한 데이터를  playerfrefab 사용하요 안드로이드 로컬저장소에 저장합니다. 이로써 게임을 완전히 껏다가 켜도 클리어데이터는 보존됩니다.

         */
   
    public Text highScoreText; //clear 여부확인
    private int savedScore;
    public int score;
    public Text limit; //게임에서만사용
    public Canvas GameOver; //게임에서만 사용
    public Text GameClear;
    public GameObject player; //게임에서만 사용
    int kill = 0;
    public float time;
    private string KeyString = "HighScore";
    // Start is called before the first frame update
    void Awake()
    {
        savedScore = PlayerPrefs.GetInt(KeyString, 0);
        score = savedScore;
        time = 1200f;
        //highScoreText.text += savedScore.ToString("0");
    }
    void Start()
    {
        if(GameOver)
        {
            GameOver.enabled = false;
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        if (limit)
        {
            if (time != 0)
            {
                time -= Time.deltaTime;
                if (time < 0)
                {
                    GameOver.enabled = true;
                    
                    time = 0;
                }
            }
            int t = Mathf.FloorToInt(time);
            limit.text = "Time: " + t.ToString();
        }
        if(score==1)
        {
            PlayerPrefs.SetInt(KeyString, score);
            highScoreText.text = "Cleared Stage: " + score;
            if (GameClear)
            {
               // GameClear.text = "STAGE CLEAR";
            }
            if (GameOver)
            {
               // GameOver.enabled = true;
            }
        }




    }
    public void ScoreUp()
    {
        score = 0;
        PlayerPrefs.SetInt(KeyString, score);
        highScoreText.text = "";
    }

    public void Restart()
    {
        SceneManager.LoadScene("start_scene");
    }
}
