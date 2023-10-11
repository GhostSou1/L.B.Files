using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonUse : MonoBehaviour
{
    public GameObject windowButton;
    public GameObject spawnPoint;
    
    public void OnClick(){
        windowButton.transform.position = spawnPoint.transform.position;
    }

    
}
