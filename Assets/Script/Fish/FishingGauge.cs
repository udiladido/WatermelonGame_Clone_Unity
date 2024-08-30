using UnityEngine;
using UnityEngine.UI;

public class FishingGauge : MonoBehaviour
{

    public static FishingGauge Instance;
    public RectTransform fishHealth;
    public float MaxGauge = 600;
    public float nowGauge = 0;
    public bool isFull = false;
    bool isStay = false;
    public Image image;




    private void Start()
    {

        Instance = this;
    

    }


    void Update()
    {

        // 줄어들기 
        if (fishHealth.sizeDelta.x > 0 && !isStay && !isFull)
        {
            nowGauge -= 0.5f;
            fishHealth.sizeDelta = new Vector2(nowGauge, 100);

        }


        

    }


    void OnTriggerStay2D(Collider2D collision)
    {

        isStay = true;


        
        //늘어나기
        if (collision.gameObject.CompareTag("Fish"))
        {

           image.color = new Color(0 / 255f, 255 / 255f, 0 / 255f);
           

            if (!isFull)
            {
                nowGauge += 1f;
                fishHealth.sizeDelta = new Vector2(nowGauge, 100);

                if (MaxGauge < nowGauge)
                { 
                    isFull = true;

                }

            }

        }

    }

    void OnTriggerExit2D(Collider2D collision)
    {

        isStay = false;
        image.color = new Color(255 / 255f, 0 / 255f, 0 / 255f);


    }





}
