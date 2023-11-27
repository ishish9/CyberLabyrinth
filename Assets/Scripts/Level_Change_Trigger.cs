using System.Collections;
using UnityEngine;

public class Level_Change_Trigger : MonoBehaviour
{
    [SerializeField] private Timer script1;
    [SerializeField] private variables script2;
    [SerializeField] private Transform lvl_finish_effect;
    [SerializeField] private ParticleSystem Plvl_finish_effect;
    [SerializeField] private AudioSource Level_complete_sound;
    [SerializeField] private AudioSource music;
    [SerializeField] private AudioSource musicFinal;
    [SerializeField] private int ChangeToLevel;
    [SerializeField] private GameObject LevelComplete;
    [SerializeField] private GameObject Player;
    [SerializeField] private GameObject UWIN;
    [SerializeField] private GameObject F1;
    [SerializeField] private GameObject F2;
    [SerializeField] private GameObject F3;
    [SerializeField] private GameObject F4;
    [SerializeField] private GameObject ScoreDisplay;
    [SerializeField] private GameObject CubeDisplay;
    [SerializeField] private GameObject TimeDisplay;
    [SerializeField] private GameObject CamMain;
    [SerializeField] private GameObject CamFireWorks;
    [SerializeField] private GameObject FinalScoreOBJ;
    [SerializeField] private bool Final;

    void OnTriggerEnter()
    {
        script2.TotalTime += script2.TotalTimeTemp -= script1.timeRemaining;
        script2.SetSavedScore();
        LevelComplete.SetActive(true);
        script1.timerIsRunning = false;
        script1.Freeze();
        lvl_finish_effect.position = transform.position;
        Plvl_finish_effect.Play();
        Level_complete_sound.Play();
        music.Stop();
        script1.ChangeLevel(ChangeToLevel);
        

        if (Final)
        {
            UWIN.SetActive(true);  
            ScoreDisplay.SetActive(false);
            CubeDisplay.SetActive(false);
            TimeDisplay.SetActive(false);     

            StartCoroutine(waitFinal());
            IEnumerator waitFinal()
            {
                yield return new WaitForSeconds(3);
                UWIN.SetActive(false);
                musicFinal.Play();
                CamMain.SetActive(false);
                CamFireWorks.SetActive(true);
                F1.SetActive(true);
                F2.SetActive(true);
                F3.SetActive(true);
                F1.SetActive(true);
                LevelComplete.SetActive(false);
                FinalScoreOBJ.SetActive(true);
                script2.FinalScoreBoard();
            }
        }
        else
        {
            StartCoroutine(waitLevelChange());
            IEnumerator waitLevelChange()
            {
                yield return new WaitForSeconds(3);
                LevelComplete.SetActive(false);
                script1.StartLevel();
                Player.SetActive(false);
            }
        }
    }
}
