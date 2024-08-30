using UnityEngine;

public class GameOverLine : MonoBehaviour
{

    public float Deadtime;


    public void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Finish"))
        {
            Deadtime += Time.deltaTime;

            if (Deadtime > 1f)
                GameManager.instance.GameOv();
                
           
        }


    }

   


}
