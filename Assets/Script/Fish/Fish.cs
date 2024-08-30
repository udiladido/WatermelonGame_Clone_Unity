using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Fish : MonoBehaviour
{

   
    public float swimspeed;
    public float swimDirection;

    public RectTransform rectTransform;
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Invoke("FishMove", 1f);

    }

    void Update()
    {


        if (FishingGauge.Instance.isFull == false)
        {

            float x = GetComponent<RectTransform>().anchoredPosition.x;
            float y = GetComponent<RectTransform>().anchoredPosition.y;

            x += swimspeed * swimDirection;

            if (x < -330)
            {
                swimDirection *= -1;
                x = -330;
                FishDir();

            }

            if (x > 330)
            {
                swimDirection *= -1;
                x = 330;
                FishDir();
            }

            rectTransform.anchoredPosition = new Vector2(x, y);


        }
        else
            CancelInvoke("FishMove");

    }



    public void FishMove()
    {
        swimspeed = Random.Range(1, 2);
        swimDirection = Random.Range(-1, 2);

        FishDir();

        float randTime = Random.Range(1,3); 
        Invoke("FishMove", randTime);

    }


    public void FishDir()
    {

        if (swimDirection < 0)
        {
            rectTransform.rotation = Quaternion.Euler(0, 180, 0);
        }
        else
            rectTransform.rotation = Quaternion.Euler(0, 0, 0);
    }


}
