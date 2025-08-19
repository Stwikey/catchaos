using UnityEngine;
using System.Collections.Generic;

public class CatObject : MonoBehaviour
{
    public List<GameObject> itemList = new List<GameObject>();
    public List<int> itemCount = new List<int>();

    public InventorySystem inventory;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public bool Ask()
    {

        for (int i = 0; i < itemList.Count; i++)
        {
            int index = inventory.InventoryObjects.IndexOf(itemList[i]);
            if (index == -1)
            {
                return false;
            }
        }

        for (int i = 0; i < itemList.Count; i++)
        {
            int indexOfItem = inventory.InventoryObjects.IndexOf(itemList[i]);
            if (inventory.InventoryCount[indexOfItem] != itemCount[i]){
                return false;
            }

        
        }

        return true;

      
    }

    private void FollowPlayer()
    {

    }
}
