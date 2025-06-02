using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static Score6;
public class QuestionFiveScript : MonoBehaviour
{
    [Header("UI Pages")]
    public GameObject mainMenu;

    [Header("Quiz Options")]
    public Button optionA;
    public Button optionB;
    public Button optionC;
    public Button optionD;

    public GameObject Right;
    public GameObject Wrong;
    public Text Score;
    public Button correctOption;
    void Start()
    {
        Right.SetActive(false);
        Wrong.SetActive(false);
        int score = Score6.score5;
        Score.text = score.ToString(); 
        optionA.onClick.AddListener(() => CheckAnswer(optionA));
        optionB.onClick.AddListener(() => CheckAnswer(optionB));
        optionC.onClick.AddListener(() => CheckAnswer(optionC));
        optionD.onClick.AddListener(() => CheckAnswer(optionD));
    }

    public void CheckAnswer(Button selectedOption)
    {
        if (selectedOption == correctOption)
        {
            int finalscore = Score6.IncrementScore();
            Right.SetActive(true);
            Wrong.SetActive(false);
            selectedOption.GetComponent<Image>().color = Color.green;
            Score.text = finalscore.ToString();
        }
        else
        {
            Wrong.SetActive(true);
            Right.SetActive(false);
            selectedOption.GetComponent<Image>().color = Color.red;
        }
    }
}
