using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextPage : MonoBehaviour
{
    public GameObject nextPage;
    public GameObject thisPage;
    
    public void OnClick(){
       nextPage.SetActive(true);
       thisPage.SetActive(false);
    }
}
