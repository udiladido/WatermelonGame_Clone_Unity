using JetBrains.Annotations;
using System.Collections;
using UnityEngine;
using UnityEngine.EventSystems;

public class FruitDrop : MonoBehaviour
{

    public GameObject Items;
    


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       
        
    }

    // Update is called once per frame
    void Update()
    {


        if (Time.timeScale != 0)
        {

            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            float x = mousePos.x;
            float y = 4.5f;
            if (x > 2.4f)
                x = 2.4f;
            else if (x < -2.4f)
                x = -2.4f;

            transform.position = new Vector2(x, y);


            if (Input.GetMouseButtonDown(0))
            {
                if (!EventSystem.current.IsPointerOverGameObject())
                    Item_Fire();

            }


        }
           


        
 

    }



    public void Item_Fire()
    {

        Instantiate(Items, transform.position, Quaternion.identity);
    }




}
