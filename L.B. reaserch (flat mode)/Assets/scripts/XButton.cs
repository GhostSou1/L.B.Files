using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XButton : MonoBehaviour
{
    public GameObject windows;
    public float exitX;
    public float exitY;
    public float exitZ;


    public void OnClick(){
        windows.transform.position = new Vector3(exitX, exitY, exitZ);
    }
}
