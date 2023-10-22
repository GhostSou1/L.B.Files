using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dissable : MonoBehaviour
{
    public GameObject StartScreen;

    public GameObject Window1;
    public GameObject Window2;
    public GameObject Window3;
    public GameObject Window4;
    
    public void OnClick(){
       StartScreen.SetActive(false);
       Window1.SetActive(true);
       Window2.SetActive(true);
       Window3.SetActive(true);
       Window4.SetActive(true);
    }
}
