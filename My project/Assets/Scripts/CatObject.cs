using UnityEngine;
using System.Collections.Generic;

public class CatObject : MonoBehaviour
{
    public string ItemName;
    public GameObject inventory;

    Animator anim;

    public GameObject house;

    [SerializeField] private float speed = 0.05f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        anim = this.GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {

    }


    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.name == "House")
        {
            Vector3 catPos = transform.position;
            Vector3 housePos = other.gameObject.transform.position;
            Vector3 direction = (housePos - catPos).normalized;
            if (direction == new Vector3(0f, 0f, 0f))
            {
                Debug.Log("going in");
                this.gameObject.SetActive(false);
                house.GetComponent<House>().catCount++;
            }
            if (direction.x > 0f)
            {
                transform.localScale = new Vector3(-2.5f, 2.5f, 2.5f);
            }
            else
            {
                transform.localScale = new Vector3(2.5f, 2.5f, 2.5f);
            }

            if (direction.y <= 0f)
            {
                anim.SetBool("isBack", false);
            }
            else
            {
                anim.SetBool("isBack", true);
            }
            transform.position += direction * speed;

        }
        else if (other.gameObject.name == "Player")
        {
            if (inventory.gameObject.GetComponent<InventorySystem>().Selected == ItemName)
            {
                Vector3 catPos = transform.position;
                Vector3 playerPos = other.gameObject.transform.position;
                Vector3 direction = (playerPos - catPos).normalized;
                if (direction.x > 0f)
                {
                    transform.localScale = new Vector3(-2.5f, 2.5f, 2.5f);
                }
                else
                {
                    transform.localScale = new Vector3(2.5f, 2.5f, 2.5f);
                }

                if (direction.y <= 0f)
                {
                    anim.SetBool("isBack", false);
                }
                else
                {
                    anim.SetBool("isBack", true);
                }
                transform.position += direction * speed;
            }
        }
        
    }
}
