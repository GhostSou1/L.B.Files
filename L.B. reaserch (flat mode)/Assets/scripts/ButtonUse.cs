using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonUse : MonoBehaviour
{
    public GameObject windowButton;
    public GameObject spawnPoint;
    public float prepare = 0f;
    public bool Wind1;
    public bool Wind2;
    public bool Wind3;
    public bool Wind4;
    
    void Start(){

        prepare = 0f;

        if(Wind1 == true){
            Wind2 = false;
            Wind3 = false;
            Wind4 = false;
        }else if(Wind2 == true){
            Wind1 = false;
            Wind3 = false;
            Wind4 = false;
        }else if(Wind3 == true){
            Wind1 = false;
            Wind2 = false;
            Wind4 = false;
        }else if(Wind4 == true){
            Wind1 = false;
            Wind2 = false;
            Wind3 = false;
        }
    }
    
    public void OnClick(){
        windowButton.transform.position = spawnPoint.transform.position;
        if(Wind1 == true){
            prepare = 1f;
        }else if(Wind2 == true){
            prepare = 2f;
        }else if(Wind3 == true){
            prepare = 3f;
        }else if(Wind4 == true){
            prepare = 4f;
        }
    }

    
}
