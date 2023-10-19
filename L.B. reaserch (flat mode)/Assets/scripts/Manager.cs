using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Manager : MonoBehaviour
{
    public GameObject Window1;
    public GameObject Window2;
    public GameObject Window3;

    private Camera _mainCamera;

    public float priority = 0;

    void Awake(){
        _mainCamera = Camera.main;
    }


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

    void Update(){

        if(priority == 1){
            Vector3 pos1 = Window1.transform.position;
            Vector3 pos2 = Window2.transform.position;
            Vector3 pos3 = Window3.transform.position;
            pos1.z = -1;
            pos2.z = 0;
            pos3.z = 0;
            Window3.transform.position = pos3;
            Window2.transform.position = pos2;
            Window1.transform.position = pos1;
            priority = 0;
        }else if(priority == 2){
            Vector3 pos1 = Window1.transform.position;
            Vector3 pos2 = Window2.transform.position;
            Vector3 pos3 = Window3.transform.position;
            pos1.z = 0;
            pos2.z = -1;
            pos3.z = 0;
            Window3.transform.position = pos3;
            Window2.transform.position = pos2;
            Window1.transform.position = pos1;
            priority = 0;
        }else if(priority == 3){
           Vector3 pos1 = Window1.transform.position;
            Vector3 pos2 = Window2.transform.position;
            Vector3 pos3 = Window3.transform.position;
            pos1.z = 0;
            pos2.z = 0;
            pos3.z = -1;
            Window3.transform.position = pos3;
            Window2.transform.position = pos2;
            Window1.transform.position = pos1;
            priority = 0;
        }
    }

    public void OnClick(InputAction.CallbackContext context){
        if(context.canceled){
            return;
        }

        var rayHit = Physics2D.GetRayIntersection(_mainCamera.ScreenPointToRay(Mouse.current.position.ReadValue()));
        if(!rayHit.collider) return;

        if(rayHit.collider.gameObject.tag == "Window_1"){
            priority = 1;
        }else if(rayHit.collider.gameObject.tag == "Window_2"){
            priority = 2;
        }else if(rayHit.collider.gameObject.tag == "Window_3"){
            priority = 3;
        }

        while(context.performed){
            if(rayHit.collider.gameObject.tag == "Window_1"){
            priority = 1;
            Vector2 pos15 = Window1.transform.position;
            pos15 = Input.mousePosition;
            Window1.transform.position = pos15;
            priority = 0;
        }else if(rayHit.collider.gameObject.tag == "Window_2"){
            priority = 2;
            Vector2 pos25 = Window2.transform.position;
            pos25 = Input.mousePosition;
            Window2.transform.position = pos25;
            priority = 0;
        }
        }
    }
}
