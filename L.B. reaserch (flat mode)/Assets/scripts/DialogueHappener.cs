using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DialogueHappener : MonoBehaviour
{

    public TextMeshProUGUI nameText;
    public TextMeshProUGUI dialogueText;
    public TextMeshProUGUI buttonText;

    public double poradie;

    public GameObject TalkBack;
    public GameObject Shadow;

    public GameObject DialogueMort;
    public GameObject questionOptions;
    public GameObject DiaWindow;

    public GameObject Optioned_1;
    public GameObject Optioned_2;
    public GameObject Optioned_3;

    public GameObject sad;
    public GameObject normalish;
    public GameObject puzzle;
    public GameObject suprise;
    public GameObject laugh;

    public GameObject Window1;
    public GameObject Window2;
    public GameObject Window3;
    public GameObject Window4;

    public bool DialogueStarting = false;
    public bool DialogueEnding = false;

    void Start()
    {
        nameText.text = "Mortimer (#001)";
        buttonText.text = "Continue";
        dialogueText.text = "HA HA HA!";
        poradie = 0;
    }

    void Update(){
        if(DialogueStarting == true){
            OnBegin();
            DialogueStarting = false;
        }
    }

    private void OnBegin(){
        StopAllCoroutines();
        StartCoroutine(TypeSentence("HA HA!"));
        laugh.SetActive(true);
    }


    public void Talk_1(){
        if(poradie == 0){
            StopAllCoroutines();
            StartCoroutine(TypeSentence("Got you Jack good!"));
            poradie = 1;
            laugh.SetActive(true);
        }else if(poradie == 1){
            StopAllCoroutines();
            StartCoroutine(TypeSentence("..."));
            poradie = 2;
            laugh.SetActive(false);
            suprise.SetActive(true);
        }else if(poradie == 2){
            StopAllCoroutines();
            StartCoroutine(TypeSentence("Wait"));
            poradie = 3;
            suprise.SetActive(true);
        }else if(poradie == 3){
            StopAllCoroutines();
            StartCoroutine(TypeSentence("You are not Jack"));
            poradie = 4;
            suprise.SetActive(false);
            puzzle.SetActive(true);
        }else if(poradie == 4){
            StopAllCoroutines();
            StartCoroutine(TypeSentence("OH NO!"));
            poradie = 5;
            suprise.SetActive(true);
            puzzle.SetActive(false);
        }else if(poradie == 5){
            StopAllCoroutines();
            StartCoroutine(TypeSentence("That means"));
            poradie = 6;
            suprise.SetActive(false);
            sad.SetActive(true);
        }else if(poradie == 6){
            StopAllCoroutines();
            StartCoroutine(TypeSentence("Event Rerecord has happened"));
            poradie = 7;
            sad.SetActive(true);
        }else if(poradie == 7){
            StopAllCoroutines();
            StartCoroutine(TypeSentence("That means you are his safety measure"));
            poradie = 8;
            sad.SetActive(false);
            puzzle.SetActive(true);
        }else if(poradie == 8){
            StopAllCoroutines();
            StartCoroutine(TypeSentence("or thats what I called it"));
            poradie = 9;
            puzzle.SetActive(true);
        }else if(poradie == 9){
            StopAllCoroutines();
            StartCoroutine(TypeSentence("Mike, Right?"));
            buttonText.text = "Yes";
            poradie = 10;
            puzzle.SetActive(true);
        }else if(poradie == 10){
            StopAllCoroutines();
            StartCoroutine(TypeSentence("..."));
            buttonText.text = "Continue";
            poradie = 11;
            puzzle.SetActive(true);
        }else if(poradie == 11){
            StopAllCoroutines();
            StartCoroutine(TypeSentence("It will take some time to recover from this news"));
            poradie = 12;
            puzzle.SetActive(false);
            sad.SetActive(true);
        }else if(poradie == 12){
            StopAllCoroutines();
            StartCoroutine(TypeSentence("But I'll have to do what Jack told me"));
            poradie = 13;
           suprise.SetActive(true);
           sad.SetActive(false);
        }else if(poradie == 13){
            StopAllCoroutines();
            StartCoroutine(TypeSentence("His instructions for when Event Record inevitably happens"));
            poradie = 13.1;
            suprise.SetActive(true);
        }else if(poradie == 13.1){
            StopAllCoroutines();
            StartCoroutine(TypeSentence("Were to answear any questions that someone named Mike would ask"));
            poradie = 14;
            suprise.SetActive(false);
            puzzle.SetActive(true);
        }else if(poradie == 14){
            StopAllCoroutines();
            StartCoroutine(TypeSentence("and so I'll do as he said"));
            poradie = 15;
            puzzle.SetActive(false);
            suprise.SetActive(true);
        }else if(poradie == 15){
            StopAllCoroutines();
            StartCoroutine(TypeSentence("just dont call me assistant"));
            poradie = 16;
            puzzle.SetActive(true);
            suprise.SetActive(false);
        }else if(poradie == 16){
            StopAllCoroutines();
            StartCoroutine(TypeSentence("So, any questions?"));
            poradie = 17;
            puzzle.SetActive(false);
            normalish.SetActive(true);
            questionOptions.SetActive(true);
            TalkBack.SetActive(true);
            Shadow.SetActive(false);
            DialogueEnding = true;
            buttonText.text = "End conversation";
        }else if(poradie == 21){
            StopAllCoroutines();
            StartCoroutine(TypeSentence("But he did tell me it will happen soon"));
            poradie = 22;
            suprise.SetActive(true);
            puzzle.SetActive(false);
        }else if(poradie == 22){
            StopAllCoroutines();
            StartCoroutine(TypeSentence("The Event Rerecord is basically the event where Jack dies of something he called Spector"));
            poradie = 23;
            suprise.SetActive(true);
        }else if(poradie == 23){
            StopAllCoroutines();
            StartCoroutine(TypeSentence("He never said what or who Spector is"));
            poradie = 24;
            suprise.SetActive(true);
        }else if(poradie == 24){
            StopAllCoroutines();
            StartCoroutine(TypeSentence("Only that it would be end of him and instruction after it"));
            poradie = 25;
            suprise.SetActive(false);
            sad.SetActive(true);
        }else if(poradie == 25){
            StopAllCoroutines();
            StartCoroutine(TypeSentence("The instructions were very simple"));
            poradie = 26;
            suprise.SetActive(true);
            sad.SetActive(false);
        }else if(poradie == 26){
            StopAllCoroutines();
            StartCoroutine(TypeSentence("Answear anything that Mike ask"));
            poradie = 27;
            suprise.SetActive(true);

        }else if(poradie == 27){
            StopAllCoroutines();
            StartCoroutine(TypeSentence("So thats what I'm doing"));
            poradie = 18;
            suprise.SetActive(true);
            Optioned_1.SetActive(false);
           
        }else if(poradie == 18){
            StopAllCoroutines();
            StartCoroutine(TypeSentence("Any other questions?"));
            poradie = 17;
            suprise.SetActive(false);
            puzzle.SetActive(false);
            sad.SetActive(false);
            laugh.SetActive(false);
            normalish.SetActive(true);
            questionOptions.SetActive(true);
            DialogueEnding = true;
            buttonText.text = "End conversation";
        }else if (poradie == 31){
            StopAllCoroutines();
            StartCoroutine(TypeSentence("But to summerize it"));
            poradie = 32;
            suprise.SetActive(true);
            laugh.SetActive(false);
        }else if (poradie == 32){
            StopAllCoroutines();
            StartCoroutine(TypeSentence("He was a scientist in Organic AI"));
            poradie = 33;
            suprise.SetActive(true);
            laugh.SetActive(false);
        }else if (poradie == 33){
            StopAllCoroutines();
            StartCoroutine(TypeSentence("That means he tried to make something by combining AI and organic matter"));
            poradie = 34;
            suprise.SetActive(true);
        }else if (poradie == 34){
            StopAllCoroutines();
            StartCoroutine(TypeSentence("At some point, Jack got his hands on Life Program"));
            poradie = 35;
            suprise.SetActive(true);
        }else if (poradie == 35){
            StopAllCoroutines();
            StartCoroutine(TypeSentence("He never said where he got it"));
            poradie = 36;
            suprise.SetActive(false);
            puzzle.SetActive(true);
        }else if (poradie == 36){
            StopAllCoroutines();
            StartCoroutine(TypeSentence("Only thing he said about it was that it is now inside this computer"));
            poradie = 37;
            suprise.SetActive(true);
            puzzle.SetActive(false);
        }else if (poradie == 37){
            StopAllCoroutines();
            StartCoroutine(TypeSentence("With this program he started experimenting"));
            poradie = 38;
            suprise.SetActive(true);
        }else if (poradie == 38){
            StopAllCoroutines();
            StartCoroutine(TypeSentence("After few mistakes, I was made"));
            poradie = 39;
            suprise.SetActive(true);
        }else if (poradie == 39){
            StopAllCoroutines();
            StartCoroutine(TypeSentence("YUP, even yours trully exists because of this program"));
            poradie = 39.1;
            suprise.SetActive(false);
            laugh.SetActive(true);
        }else if (poradie == 39.1){
            StopAllCoroutines();
            StartCoroutine(TypeSentence("Last thing he ever said to me was the Event Rerecord"));
            poradie = 39.2;
            puzzle.SetActive(true);
            laugh.SetActive(false);
        }else if (poradie == 39.2){
            StopAllCoroutines();
            StartCoroutine(TypeSentence("Life is sometimes pain in the butt"));
            poradie = 18;
            puzzle.SetActive(false);
            sad.SetActive(true);
            Optioned_2.SetActive(false);
        }else if (poradie == 41){
            StopAllCoroutines();
            StartCoroutine(TypeSentence("After builting in Life Program, it merged with some code in the computer"));
            poradie = 42;
            suprise.SetActive(true);
        }else if (poradie == 42){
            StopAllCoroutines();
            StartCoroutine(TypeSentence("Following was creation of us, the Living Bytes"));
            poradie = 43;
            suprise.SetActive(false);
            laugh.SetActive(true);
        }else if (poradie == 43){
            StopAllCoroutines();
            StartCoroutine(TypeSentence("There were discovered 140 different types of L.Bs"));
            poradie = 44;
            normalish.SetActive(true);
            laugh.SetActive(false);
        }else if (poradie == 44){
            StopAllCoroutines();
            StartCoroutine(TypeSentence("You can read about them in the L.B. files application"));
            poradie = 45;
            normalish.SetActive(false);
            suprise.SetActive(true);
        }else if (poradie == 45){
            StopAllCoroutines();
            StartCoroutine(TypeSentence("Thou it doesn't seem to be anyway to reach them right now"));
            poradie = 46;
            puzzle.SetActive(true);
            suprise.SetActive(false);
        }else if (poradie == 46){
            StopAllCoroutines();
            StartCoroutine(TypeSentence("Maybe they will be available some time later"));
            poradie = 47;
            puzzle.SetActive(false);
            suprise.SetActive(true);
        }else if (poradie == 47){
            StopAllCoroutines();
            StartCoroutine(TypeSentence("Maybe some day the system will update to allow you to talk to them"));
            poradie = 48;
            laugh.SetActive(true);
            suprise.SetActive(false);
        }else if (poradie == 48){
            StopAllCoroutines();
            StartCoroutine(TypeSentence("Only future knows what will happen"));
            poradie = 18;
            laugh.SetActive(true);
            Optioned_3.SetActive(false);
        }else if(DialogueEnding == true && poradie == 18 || DialogueEnding == true && poradie == 17 || DialogueEnding == true && poradie == 19){
            StopAllCoroutines();
            StartCoroutine(TypeSentence("Well if you want to talk to me again you can find me in gallery"));
            questionOptions.SetActive(false);
            poradie = 1110;
        }else if(DialogueEnding == true && poradie == 1110){
            StopAllCoroutines();
            DiaWindow.SetActive(false);
            normalish.SetActive(false);
        }
    }

    public void Talk_2(){
        if(poradie == 17 || poradie == 18 || poradie == 19){    
            StopAllCoroutines();
            StartCoroutine(TypeSentence("Well Jack didn't said to much"));
            poradie = 21;
            normalish.SetActive(false);
            puzzle.SetActive(true);
            questionOptions.SetActive(false);
            buttonText.text = "Continue";
            DialogueEnding = false;
    }
    }

    public void Talk_3(){
        if(poradie == 17 || poradie == 18 || poradie == 19){    
            StopAllCoroutines();
            StartCoroutine(TypeSentence("Better question would be what I dont know!"));
            poradie = 31;
            normalish.SetActive(false);
            laugh.SetActive(true);
            questionOptions.SetActive(false);
            buttonText.text = "Continue";
            DialogueEnding = false;
    }
    }

    public void Talk_4(){
        if(poradie == 17 || poradie == 18 || poradie == 19){    
            StopAllCoroutines();
            StartCoroutine(TypeSentence("Living Bytes are actual living programs"));
            poradie = 41;
            normalish.SetActive(false);
            suprise.SetActive(true);
            questionOptions.SetActive(false);
            buttonText.text = "Continue";
            DialogueEnding = false;
    }
    }

    public void BackTalk(){
       DiaWindow.SetActive(true);    
       StartCoroutine(TypeSentence("Welcome back! Any other questions")); 
       questionOptions.SetActive(true);
       poradie = 19;
       normalish.SetActive(true);
       DialogueEnding = true;
       Window1.transform.position = new Vector3(0, 15, 0);
       Window2.transform.position = new Vector3(0, 15, 0);
       Window3.transform.position = new Vector3(0, 15, 0);
       Window4.transform.position = new Vector3(0, 15, 0);
    }
        
   

    IEnumerator TypeSentence (string sentence){
            dialogueText.text ="";
            foreach(char letter in sentence.ToCharArray()){
            dialogueText.text += letter;
            FindObjectOfType<AudioManager>().Play("boop");
            yield return null;
        }
   }
}
