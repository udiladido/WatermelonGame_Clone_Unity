using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public GameObject[] gameObjects;
    public GameObject UI;


    public List<Resolution> resolution = new List<Resolution>();



    public int stage = 1;


    private void Awake()
    {

        Application.targetFrameRate = 60;

        if (instance == null)
        {

            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);

        }

    }


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        Application.targetFrameRate = 60;
   

   
    }

    // Update is called once per frame
    void Update()
    {

    }


    public void SpawnObj()
    {

        int rand = Random.Range(1,8);

        // Instantiate(gameObject);
    
    
    }

    public void GameOv()
    {
        UI.gameObject.SetActive(true);
        Time.timeScale = 0f;

    }



}




 [System.Serializable]
public class Resolution
{
    public int horizontal, vertical;



}
 

