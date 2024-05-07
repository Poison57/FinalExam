using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NameSetter : MonoBehaviour
{

    public Text NameText;
    private NameHolder NameGrab;
    // Start is called before the first frame update
    void Start()
    {

        NameGrab = GameObject.Find("NameHolder").GetComponent<NameHolder>();
        NameText.text = NameGrab.name;

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}