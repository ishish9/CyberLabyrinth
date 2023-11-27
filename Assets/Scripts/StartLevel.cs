using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartLevel : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;
    [SerializeField] private GameObject ballOBJ;
    [SerializeField] private Transform ball;
    [SerializeField] private Transform SpawnEffects;
    [SerializeField] private AudioSource LevelRespawnSound;
    [SerializeField] private ParticleSystem Pspawneffects;
    [SerializeField] private Timer script;
    [SerializeField] private variables script2;
    [SerializeField] private Transform[] Level;

    void Start()
    {
        Application.targetFrameRate = 120;
        Screen.sleepTimeout = SleepTimeout.NeverSleep;
        LevelRespawnSound.Play();
        
            switch (script.GetCurrentLevel())
            {
                case 0:
                    script.SetTimer(10);
                    ball.transform.position = Level[1].transform.position;
                    break;
                case 1:
                    script.SetTimer(10);
                    ball.position = Level[1].position;
                    break;
                case 2:
                    script.SetTimer(10);
                    ball.position = Level[2].position;
                    break;
                case 3:
                    script.SetTimer(10);
                    ball.position = Level[3].position;
                    break;
                case 4:
                    script.SetTimer(25);
                    ball.position = Level[4].position;
                    break;
                case 5:
                    script.SetTimer(25);
                    ball.position = Level[5].position;
                    break;
                case 6:
                    script.SetTimer(35);
                    ball.position = Level[6].position;
                    break;
                case 7:
                    script.SetTimer(15);
                    ball.position = Level[7].position;
                    break;
                case 8:
                    script.SetTimer(70);
                    ball.position = Level[8].position;
                    break;
                case 9:
                    script.SetTimer(15);
                    ball.position = Level[9].position;
                    break;
                case 10:
                    script.SetTimer(25);
                    ball.position = Level[10].position;
                    break;
                case 11:
                    script.SetTimer(20);
                    ball.position = Level[11].position;
                    break;
                case 12:
                    script.SetTimer(20);
                    ball.position = Level[12].position;
                    break;
                case 13:
                    script.SetTimer(30);
                    ball.position = Level[13].position;
                    break;
                case 14:
                    script.SetTimer(40);
                    ball.position = Level[14].position;
                    break;
                case 15:
                    script.SetTimer(20);
                    ball.position = Level[15].position;
                    break;
                case 16:
                    script.SetTimer(30);
                    ball.position = Level[16].position;
                    break;
                case 17:
                    script.SetTimer(75);
                    ball.position = Level[17].position;
                    break;
                case 18:
                    script.SetTimer(30);
                    ball.position = Level[18].position;
                    break;
                case 19:
                    script.SetTimer(75);
                    ball.position = Level[19].position;
                    break;
                case 20:
                    script.SetTimer(150);
                    ball.position = Level[20].position;
                    break;             
            }
        script2.TotalTimeTemp = script.timeRemaining;

        rb.constraints = RigidbodyConstraints.FreezeAll;
        SpawnEffects.position = ball.position;
        Pspawneffects.Play();

        StartCoroutine(w1());
        IEnumerator w1()
        {
            yield return new WaitForSeconds(2);
            rb.constraints = RigidbodyConstraints.None;
            Timer.instance.timerIsRunning = true;
            ballOBJ.SetActive(true);
        }
    }
}
