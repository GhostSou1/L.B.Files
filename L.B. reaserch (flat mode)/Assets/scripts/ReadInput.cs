using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReadInput : MonoBehaviour
{
    private string Input;

    public float EventValue = 0f;

    public void ReadStringInput(string r){
        Input = r;
        if(Input == "TheRatHelp" && EventValue == 0f){
            EventValue = 1f;
        }
    }
}
