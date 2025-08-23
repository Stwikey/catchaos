using UnityEngine;
using System.Collections.Generic;

public class InventorySystem : MonoBehaviour
{
    public List<string> InventoryNames = new List<string>();
    public List<GameObject> InventoryObjects = new List<GameObject>();
    public List<int> InventoryCount = new List<int>();
    public GameObject bar;
    public GameObject hover;

    public string Selected = "Nothing";
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void AddToInventory(GameObject obj)
    {
        int index = InventoryNames.IndexOf(obj.gameObject.name);
        if (index == -1)
        {
            InventoryNames.Add(obj.gameObject.name);
            InventoryCount.Add(1);
            InventoryObjects.Add(obj.gameObject);
        }
        else
        {
            InventoryCount[index]++;
        }
        UpdateInventory();

    }

    private void OnMouseDown()
    {
        bar.SetActive(!bar.gameObject.activeSelf);
    }

    private void UpdateInventory()
    {
        for (int i = 0; i < InventoryObjects.Count; i++)
        {
            SpriteRenderer img = InventoryObjects[i].GetComponent<SpriteRenderer>();
            SpriteRenderer slot = transform.Find("Bar/" + i.ToString()).GetComponent<SpriteRenderer>();
            slot.sprite = img.sprite;
            slot.gameObject.GetComponent<Slots>().idName = InventoryObjects[i].gameObject.name;
            transform.Find("Bar/" + i.ToString()).GetComponent<Slots>().UpdateText(InventoryCount[i].ToString());
        }
    }

    void OnMouseOver()
    {
        hover.SetActive(true);
    }

    void OnMouseExit() {
        hover.SetActive(false);
    }

   


    

}
