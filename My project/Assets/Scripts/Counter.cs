using System.Collections.Generic;
using JetBrains.Annotations;
using Unity.Burst.CompilerServices;
using UnityEngine;

public class Counter : MonoBehaviour
{
    public GameObject house;
    public List<Sprite> s;
    SpriteRenderer render;
    public int count;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        render = this.gameObject.GetComponent<SpriteRenderer>();
        
    }

    // Update is called once per frame
    void Update()
    {
        count = house.GetComponent<House>().catCount;
        render.sprite = s[count];
    }
}
    