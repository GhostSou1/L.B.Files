using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    public GameObject Window1;
    public GameObject Window2;
    public GameObject Window3;



    void Start()
    {
        Vector3 pos1 = Window1.transform.position;
        Vector3 pos2 = Window2.transform.position;
        Vector3 pos3 = Window3.transform.position;
        pos1.z = 0;
        pos2.z = 0;
        pos3.z = 0;
        Window3.transform.position = pos3;
        Window2.transform.position = pos2;
        Window1.transform.position = pos1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
