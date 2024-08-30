using UnityEngine;
using UnityEngine.UI;

public class FishAreaMove : MonoBehaviour
{

    public static FishAreaMove instance;
    public bool isRight = false;
    public bool isLeft = false;
    public int direction = 1;
    public float speed = 0.5f;
   
    public RectTransform rectTransform;



    private void Start()
    {
        
    }



    private void Update()
    {
        float x = GetComponent<RectTransform>().anchoredPosition.x;
        float y = GetComponent<RectTransform>().anchoredPosition.y;


        if (isRight || isLeft)
        {

            x += speed * direction;

            if (x < -280)
            {
                x = -280; 
            }

            if (x > 280)
            {
                x = 280;

            }

            rectTransform.anchoredPosition = new Vector2(x, y);

        }
       



    }




    public void RightMove()
    {
        isRight = true;
        direction = 1;
    }


    public void LeftMove() 
    { 
    
        isLeft = true;
        direction = -1;
    }

    public void RightMoveUp()
    {
        isRight = false;
    }


    public void LeftMoveUp()
    {

        isLeft = false;

    }


   

}
