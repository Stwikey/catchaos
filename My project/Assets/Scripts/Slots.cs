using UnityEngine;

public class Slots : MonoBehaviour
{
    //public TMPro.TextMeshProUGUI txt;
    public GameObject highlight;
    public string idName;
    private bool clicked = false;

    public GameObject inventory;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        highlight.SetActive(false);
        //txt.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        if (inventory.gameObject.GetComponent<InventorySystem>().Selected != idName)
        {
            highlight.SetActive(false);
            clicked = false;
        }

        if (inventory.gameObject.GetComponent<InventorySystem>().Selected == idName)
        {
            highlight.SetActive(true);
            clicked = true;
        }

    }
    public void UpdateText(string number)
    {
        //txt.text = number;
    }

    private void OnMouseOver()
    {
        highlight.SetActive(true);
    }

    private void OnMouseExit()
    {
        if (clicked == false)
        {
            highlight.SetActive(true);
        }
    }

    private void OnMouseDown()
    {
        if (clicked == true)
        {
            clicked = false;
            inventory.GetComponent<InventorySystem>().Selected = "Nothing";
        }
        else
        {
            clicked = true;
            inventory.gameObject.GetComponent<InventorySystem>().Selected = idName;


        }
    }


}
