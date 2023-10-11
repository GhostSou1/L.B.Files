using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XButton : MonoBehaviour
{
    public GameObject windows;
 
    
    public void OnClick(){
        windows.transform.position = new Vector3(-19.42f, 3.89f, 0f) ;
    }
}
