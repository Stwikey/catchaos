using UnityEngine;

public class Slots : MonoBehaviour
{
    //public TMPro.TextMeshProUGUI txt;
    public GameObject highlight;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        highlight.SetActive(false);
        //txt.text = "";
    }

    // Update is called once per frame
    void Update()
    {

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
        highlight.SetActive(false);
    }
}
