using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DialogueManager : MonoBehaviour
{
    private Queue<string> senteces;

    public TextMeshProUGUI nameText;
    public TextMeshProUGUI dialogueText;


    void Start()
    {
        senteces = new Queue<string>();
    }

    public void StartDialogue(Dialogue dialogue){
        senteces.Clear();

        nameText.text = dialogue.name;

        foreach (string sentence in dialogue.senteces){
            senteces.Enqueue(sentence);
        }

        DisplayNextSentece();
    }

  
        
    public void DisplayNextSentece(){
         if(senteces.Count == 0){
            EndDialogue();
            return;
        }

        string sentece = senteces.Dequeue();
        StopAllCoroutines();
        StartCoroutine(TypeSentence(sentece));
    }

    IEnumerator TypeSentence (string sentence){
        dialogueText.text ="";
        foreach(char letter in sentence.ToCharArray()){
            dialogueText.text += letter;
            FindObjectOfType<AudioManager>().Play("boop");
            yield return null;
        }
    }

    void EndDialogue(){
        Debug.Log("End of convo");
    }
    

    
}
