using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    

  
    public void LoadGame(int num)
    {
        SceneManager.LoadScene($"MainGame{num}");
        Debug.Log(num);
        Screen.SetResolution(GameManager.instance.resolution[num].horizontal, GameManager.instance.resolution[num].vertical, true); 

    }

    public void RestartScene()
    {
        Scene scene = SceneManager.GetActiveScene(); 
        SceneManager.LoadScene($"{scene.name}");

    }

    public void GameQuit()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit(); // 어플리케이션 종료
#endif

    }


    public void GameReturn()
    { 
        Time.timeScale = 1.0f;

    }

    public void GameStop()
    {

        Time.timeScale = 0;

    }

}
