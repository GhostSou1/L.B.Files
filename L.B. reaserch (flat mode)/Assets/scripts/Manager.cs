using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class Manager : MonoBehaviour
{
    public GameObject Window1;
    public GameObject Window2;
    public GameObject Window3;
    public GameObject Notes;

    public TextMeshProUGUI bootingText;

    private Camera _mainCamera;

    public ReadInput theCode;

    float priority = 0;

    public GameObject IntroAnimation;

    public ButtonUse use1;
    public ButtonUse use2;
    public ButtonUse use3;

    public GameObject jumpScare;
    public GameObject DialogueBox;

    public DialogueHappener Dialoguestart;

    void Awake(){
        _mainCamera = Camera.main;
    }


    void Start()
    {
        StartCoroutine(Intro());

        Vector3 pos1 = Window1.transform.position;
        Vector3 pos2 = Window2.transform.position;
        Vector3 pos3 = Window3.transform.position;
        pos1.z = -1;
        pos2.z = 0;
        pos3.z = -2;
        Window3.transform.position = pos3;
        Window2.transform.position = pos2;
        Window1.transform.position = pos1;


    }

    void Update(){

        if(theCode.EventValue == 1f){
            StartCoroutine(WhenEventStarts());
            theCode.EventValue = 3f;
        }




       if(priority == 1 || use1.prepare == 1f){
            Vector3 pos1 = Window1.transform.position;
            Vector3 pos2 = Window2.transform.position;
            Vector3 pos3 = Window3.transform.position;
            pos1.z = -2;
            pos2.z = 0;
            pos3.z = -1;
            Window3.transform.position = pos3;
            Window2.transform.position = pos2;
            Window1.transform.position = pos1;
            priority = 0;
            use1.prepare = 0f;
        }else if(priority == 2 || use1.prepare == 2f){
            Vector3 pos1 = Window1.transform.position;
            Vector3 pos2 = Window2.transform.position;
            Vector3 pos3 = Window3.transform.position;
            pos1.z = -1;
            pos2.z = -2;
            pos3.z = 0;
            Window3.transform.position = pos3;
            Window2.transform.position = pos2;
            Window1.transform.position = pos1;
            priority = 0;
            use2.prepare = 0f;
        }else if(priority == 3 || use1.prepare == 3f){
            Vector3 pos1 = Window1.transform.position;
            Vector3 pos2 = Window2.transform.position;
            Vector3 pos3 = Window3.transform.position;
            pos1.z = -1;
            pos2.z = 0;
            pos3.z = -2;
            Window3.transform.position = pos3;
            Window2.transform.position = pos2;
            Window1.transform.position = pos1;
            priority = 0;
            use3.prepare = 0f;
        }
    }

    public void OnClick(InputAction.CallbackContext context){
        if(context.canceled){
            FindObjectOfType<AudioManager>().Play("Click");
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
    }


    IEnumerator WhenEventStarts(){
        
        Window1.transform.position = new Vector3(0, 15, 0);
        Window2.transform.position = new Vector3(0, 15, 0);
        Window3.transform.position = new Vector3(0, 15, 0);
        Notes.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;

        FindObjectOfType<AudioManager>().StopPlaying("Fan");
        FindObjectOfType<AudioManager>().Play("shutdown");
        yield return new WaitForSeconds(3);      
        yield return new WaitForSeconds(5);
        jumpScare.SetActive(true);
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        FindObjectOfType<AudioManager>().Play("Jumpscare");
        
        yield return new WaitForSeconds(1);
        FindObjectOfType<AudioManager>().Play("Fan");
        jumpScare.SetActive(false);
        Dialoguestart.DialogueStarting = true;
        DialogueBox.SetActive(true);
    }

    IEnumerator Intro(){
        FindObjectOfType<AudioManager>().Play("booting");
        yield return new WaitForSeconds(6);
        bootingText.text = "welcome back";
        FindObjectOfType<AudioManager>().Play("Fan");
        yield return new WaitForSeconds(1);
        IntroAnimation.SetActive(false);
    }
}
