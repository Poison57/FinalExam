using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetManager : MonoBehaviour
{

    public GameObject target;
    // Start is called before the first frame update
    void Start()
    {
        CreateTargets();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CreateTargets(){

        Vector3 position;
        for(int i = 0; i < 5; i++){
            position = new Vector3(Random.Range(-4.0f, 4.0f), 1, Random.Range(-4.0f, 4.0f));
            Instantiate(target, position, Quaternion.identity);

        }

    }
}
