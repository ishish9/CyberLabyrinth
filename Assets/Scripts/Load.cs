using UnityEngine;
using UnityEngine.SceneManagement;

public class Load : MonoBehaviour
{ 
    public GameObject loadingtext;

    public void LoadLevel()
    {
        loadingtext.SetActive(true);
        SceneManager.LoadScene("Level_1");
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
