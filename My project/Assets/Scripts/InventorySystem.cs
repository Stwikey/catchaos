using UnityEngine;
using System.Collections.Generic;

public class InventorySystem : MonoBehaviour
{
    public List<string> InventoryNames = new List<string> ();
    public List<GameObject> InventoryObjects = new List<GameObject> ();
    public List<int> InventoryCount = new List<int> ();
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddToInventory(GameObject obj){
        int index = InventoryNames.IndexOf(obj.gameObject.name);
        if (index == -1){
            InventoryNames.Add(obj.gameObject.name);
            InventoryCount.Add(0);
        }else{
            InventoryCount[index]++;
        }
      
    }


    

}
