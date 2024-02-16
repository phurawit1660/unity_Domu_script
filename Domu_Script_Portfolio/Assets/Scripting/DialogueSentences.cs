using System.Collections;
using TMPro;
using UnityEngine;


public class DialogueSentences : MonoBehaviour
{
    [SerializeField] GameObject nextButtom;
    [SerializeField] TMP_Text dialogueText;
    [SerializeField] float speedSentences;
    [TextArea(3, 10)]
    [SerializeField] string[] sentences;

    private int index;
    // Start is called before the first frame update
    void Start()
    {
        nextButtom.SetActive(false);
        dialogueText.text = string.Empty;
        index = 0;
        StartCoroutine(TypeLine());

    }

    // Update is called once per frame
    void Update()
    {
        if (dialogueText.text == sentences[index])
        {
            nextButtom.SetActive(true);
        }
    }

    public void ClickNextSentences()
    {


        if (dialogueText.text == sentences[index])
        {
            NextLine();
        }
        else
        {
            StopAllCoroutines();
            dialogueText.text = sentences[index];
        }
    }

    void StartDialogue()
    {
        index = 0;
        StartCoroutine(TypeLine());
    }

    IEnumerator TypeLine()
    {
        foreach (char c in sentences[index].ToCharArray())
        {
            dialogueText.text += c;
            yield return new WaitForSeconds(speedSentences);
        }
    }

    void NextLine()
    {
        nextButtom.SetActive(false);

        if (index < sentences.Length - 1)
        {
            index++;

            dialogueText.text = string.Empty;
            StartCoroutine(TypeLine());

        }
        else
        {
            Debug.Log("End");
        }
    }
}

