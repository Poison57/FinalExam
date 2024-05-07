using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SizeManager : MonoBehaviour
{
    public float size;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        size = SliderManager.size;
        Vector3 scale = new Vector3(size, size, size);
        this.transform.localScale = scale;
    }

  
}
