using System.Collections;
using UnityEngine;

public class ItemMerge : MonoBehaviour
{
    

    public int level;
    public SpriteRenderer spriteRenderer;
    public bool isMerge;
    public ItemInfo[] Iteminfos;


    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();   

        
    }



    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Item")) 
        {
            ItemMerge other = collision.gameObject.GetComponent<ItemMerge>();


            if (level == other.level && !isMerge && !other.isMerge && level < 5)
            {

                other.StartCoroutine("CoolTime");
                gameObject.SetActive(false);
            }

        }
       
      
    }

    IEnumerator CoolTime()
    {
        isMerge = true;
        yield return new WaitForSeconds(0.25f);
        isMerge = false;

        if (level < 5)
            level++;

        spriteRenderer.sprite = Iteminfos[level].sprite;
    }

}

