using UnityEngine;
using System.Collections.Generic;

public class CatObject : MonoBehaviour
{
    public string ItemName;
    public GameObject inventory;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void FollowPlayer()
    {



    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.name == "Player")
        {
            if (inventory.gameObject.GetComponent<InventorySystem>().Selected == ItemName)
            {
                Debug.Log(this.gameObject.name);
            }
           

        }
    }
}
