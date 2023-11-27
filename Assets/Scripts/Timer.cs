using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    [SerializeField] private Text TimerText;
    [SerializeField] private Rigidbody rb;
    [SerializeField] private GameObject PlayerOBJ;
    [SerializeField] private Transform Player;
    [SerializeField] private Transform[] RespawnPositions;
    [SerializeField] private Transform parentTransform;
    [SerializeField] private GameObject TimeoutDisplay;
    [SerializeField] private GameObject RestartButton;
    [SerializeField] private ParticleSystem Pspawneffects;
    [SerializeField] private AudioSource music;
    [SerializeField] private AudioSource RestartSound;
    [SerializeField] private AudioSource FailSound;
    [SerializeField] private variables script1;
    [SerializeField] private Menu script2;
    [SerializeField] private int time;
    [SerializeField] private int indexPosition;
    public float timeRemaining = 0;
    public bool timerIsRunning = false;
    public static Timer instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }


    private void Update()
    {
        if (timerIsRunning)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
                TimerText.text = timeRemaining.ToString("0");
            }
            else
            {
                rb.constraints = RigidbodyConstraints.FreezeAll;
                timerIsRunning = false;
                if (timeRemaining <= 0)
                {
                    TimeoutDisplay.SetActive(true);
                }
                timeRemaining = 0;
                music.Stop();
                FailSound.Play();

                StartCoroutine(wait());
                IEnumerator wait()
                {
                    yield return new WaitForSeconds(3);
                    RestartButton.SetActive(true);
                    PlayerOBJ.SetActive(false);
                }
            }
        }
    }

    public void Restart()
    {
        if (script2.isOnCheck() == true)
        {
            music.Play();
        }
        else
        {
            music.Pause();
        }
        RestartSound.Play();
        RestartButton.SetActive(false);
        TimeoutDisplay.SetActive(false);
        timeRemaining = 0;
        rb.constraints = RigidbodyConstraints.None;
        script1.RestoreScoreAfterDeath();

        switch (GetCurrentLevel())
        {
            case 0:
                SetTimer(10);
                Player.position = RespawnPositions[1].position;
                break;
            case 1:
                SetTimer(10);
                Player.position = RespawnPositions[1].position;
                break;
            case 2:
                SetTimer(10);
                Player.position = RespawnPositions[2].position;
                break;
            case 3:
                SetTimer(10);
                Player.position = RespawnPositions[3].position;
                break;
            case 4:
                SetTimer(25);
                Player.position = RespawnPositions[4].position;
                break;
            case 5:
                SetTimer(25);
                Player.position = RespawnPositions[5].position;
                break;
            case 6:
                SetTimer(35);
                Player.position = RespawnPositions[6].position;
                break;
            case 7:
                SetTimer(15);
                Player.position = RespawnPositions[7].position;
                break;
            case 8:
                SetTimer(60);
                Player.position = RespawnPositions[8].position;
                break;
            case 9:
                SetTimer(20);
                Player.position = RespawnPositions[9].position;
                break;
            case 10:
                SetTimer(25);
                Player.position = RespawnPositions[10].position;
                break;
            case 11:
                SetTimer(20);
                Player.position = RespawnPositions[11].position;
                break;
            case 12:
                SetTimer(20);
                Player.position = RespawnPositions[12].position;
                break;
            case 13:
                SetTimer(20);
                Player.position = RespawnPositions[13].position;
                break;
            case 14:
                SetTimer(20);
                Player.position = RespawnPositions[14].position;
                break;
            case 15:
                SetTimer(15);
                Player.position = RespawnPositions[15].position;
                break;
            case 16:
                SetTimer(30);
                Player.position = RespawnPositions[16].position;
                break;
            case 17:
                SetTimer(65);
                Player.position = RespawnPositions[17].position;
                break;
            case 18:
                SetTimer(15);
                Player.position = RespawnPositions[18].position;
                break;
            case 19:
                SetTimer(45);
                Player.position = RespawnPositions[19].position;
                break;
            case 20:
                SetTimer(160);
                Player.position = RespawnPositions[20].position;
                break;
        }

        script1.TotalTimeTemp = timeRemaining;
        rb.constraints = RigidbodyConstraints.FreezeAll;
        Pspawneffects.transform.position = Player.position;
        Pspawneffects.Play();

        StartCoroutine(waitRestart());
        IEnumerator waitRestart()
        {
            yield return new WaitForSeconds(2);
            rb.constraints = RigidbodyConstraints.None;
            timerIsRunning = true;
            PlayerOBJ.SetActive(true);
            for (int j = 0; j < parentTransform.childCount; j++)
            {
                parentTransform.GetChild(j).gameObject.SetActive(true);
            }
        }
    }

    public void StartLevel()
    {

        if (script2.isOnCheck() == true)
        {
            music.Play();
        }
        else
        {
            music.Pause();
        }
        RestartSound.Play();
        TimeoutDisplay.SetActive(false);
        timeRemaining = 0;
        rb.constraints = RigidbodyConstraints.None;
        

        switch (GetCurrentLevel())
        {
            case 0:
                SetTimer(10);
                Player.position = RespawnPositions[1].position;
                break;
            case 1:
                SetTimer(10);
                Player.position = RespawnPositions[1].position;
                break;
            case 2:
                SetTimer(10);
                Player.position = RespawnPositions[2].position;
                break;
            case 3:
                SetTimer(10);
                Player.position = RespawnPositions[3].position;
                break;
            case 4:
                SetTimer(25);
                Player.position = RespawnPositions[4].position;
                break;
            case 5:
                SetTimer(25);
                Player.position = RespawnPositions[5].position;
                break;
            case 6:
                SetTimer(35);
                Player.position = RespawnPositions[6].position;
                break;
            case 7:
                SetTimer(15);
                Player.position = RespawnPositions[7].position;
                break;
            case 8:
                SetTimer(60);
                Player.position = RespawnPositions[8].position;
                break;
            case 9:
                SetTimer(20);
                Player.position = RespawnPositions[9].position;
                break;
            case 10:
                SetTimer(25);
                Player.position = RespawnPositions[10].position;
                break;
            case 11:
                SetTimer(20);
                Player.position = RespawnPositions[11].position;
                break;
            case 12:
                SetTimer(20);
                Player.position = RespawnPositions[12].position;
                break;
            case 13:
                SetTimer(20);
                Player.position = RespawnPositions[13].position;
                break;
            case 14:
                SetTimer(20);
                Player.position = RespawnPositions[14].position;
                break;
            case 15:
                SetTimer(15);
                Player.position = RespawnPositions[15].position;
                break;
            case 16:
                SetTimer(30);
                Player.position = RespawnPositions[16].position;
                break;
            case 17:
                SetTimer(65);
                Player.position = RespawnPositions[17].position;
                break;
            case 18:
                SetTimer(15);
                Player.position = RespawnPositions[18].position;
                break;
            case 19:
                SetTimer(45);
                Player.position = RespawnPositions[19].position;
                break;
            case 20:
                SetTimer(160);
                Player.position = RespawnPositions[20].position;
                break;
        }

        script1.TotalTimeTemp = timeRemaining;
        rb.constraints = RigidbodyConstraints.FreezeAll;
        Pspawneffects.transform.position = Player.position;
        Pspawneffects.Play();
        RestartButton.SetActive(false);

        StartCoroutine(waitStartLevel());
        IEnumerator waitStartLevel()
        {
            yield return new WaitForSeconds(2);
            rb.constraints = RigidbodyConstraints.None;
            timerIsRunning = true;
            PlayerOBJ.SetActive(true);
            for (int j = 0; j < parentTransform.childCount; j++)
            {
                parentTransform.GetChild(j).gameObject.SetActive(true);
            }
        }
    }

    public void SetTimer(int time)
    {
        timeRemaining += time;
    }

    public void FallDeath()
    {
        timerIsRunning = false;
        music.Stop();

        StartCoroutine(wait());
        IEnumerator wait()
        {
            yield return new WaitForSeconds(2);
            RestartButton.SetActive(true);
        }
    }

    public void ChangeLevel(int level)
    {
        indexPosition = level;
    }

    public int GetCurrentLevel()
    {
         
        return indexPosition;
    }


    public void Freeze()
    {
        rb.constraints = RigidbodyConstraints.FreezeAll;
    }

}

