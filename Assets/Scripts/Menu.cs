using UnityEngine;

public class Menu : MonoBehaviour
{
    [SerializeField] private GameObject MenuUI;
    [SerializeField] private GameObject Options;
    [SerializeField] private AudioSource music;
    [SerializeField] private Rigidbody rb;
    public static bool isOn = true;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            // Activates Menu
            if (MenuUI.activeSelf == false)
            {
                MenuUI.gameObject.SetActive(true);
                Options.gameObject.SetActive(false);
                rb.freezeRotation = true;
                rb.isKinematic = true;
            }

            // Deactivates Menu        
            else
            {
                MenuUI.gameObject.SetActive(false);
                rb.freezeRotation = false;
                rb.isKinematic = false;
            }
        }
    }

    public void MusicToggle()
    {
        if (music.isPlaying)
        {
            music.Pause();
            isOn = false;
        }
        else
        {
            music.Play();
            isOn = true;
        }
    }

    public void ExitApp()
    {
        Application.Quit();
    }

    public bool isOnCheck()
    {
        if (isOn == true)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public void toggleOff()
    {
        isOn = false;
    }

    public void toggleOn()
    {
        isOn = true;
    }
}
