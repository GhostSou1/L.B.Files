using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enabled : MonoBehaviour
{
    public GameObject Start_Screen;

    public GameObject Window1;
    public GameObject Window2;
    public GameObject Window3;
    public GameObject Window4;
    
    public void OnClick(){
       Start_Screen.SetActive(true);
       Window1.SetActive(false);
       Window2.SetActive(false);
       Window3.SetActive(false);
       Window4.SetActive(false);

    }
}
