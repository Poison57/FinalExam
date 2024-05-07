using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderManager : MonoBehaviour
{
    public Slider mySlider; 
    public Text sizeText;
    public static float size;

    // Update is called once per frame
    void Update()
    {
        size = mySlider.value;
        sizeText.text = size.ToString("f2"); 
    }
}
