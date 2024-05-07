using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorChanger : MonoBehaviour
{
    public Dropdown ColorDropdown;
    public GameObject Player;



    void Start()
    {
        Player.GetComponent<Renderer>().material.color = Color.black;
    }

 
    void Update()
    {
        
    }
    public void ChooseColor() 
    {
        switch (ColorDropdown.value)
        {
            case 1:
                Player.GetComponent<Renderer>().material.color = Color.red;
                break;
            case 2:
                Player.GetComponent<Renderer>().material.color = Color.white;
                break;
            case 3:
                Player.GetComponent<Renderer>().material.color = Color.blue;
                break;
            default: 
                Player.GetComponent<Renderer>().material.color = Color.black;
                break;
        }
    }
   
}