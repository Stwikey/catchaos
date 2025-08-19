using UnityEngine;

public class Slots : MonoBehaviour
{
    public TMPro.TextMeshProUGUI txt;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        txt.text = "";
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void UpdateText(string number)
    {
        txt.text = number;
    }
}
