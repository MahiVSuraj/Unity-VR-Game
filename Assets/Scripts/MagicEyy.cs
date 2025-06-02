using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
// using UnityEngine.SceneManagement;

public class MagicEyy : MonoBehaviour
{
    //  public FadeScreen fadeScreen;
    [Header("UI Pages")]
    public GameObject mainMenu;

    [Header("Quiz Options")]
    public Button optionA;
    public Button optionB;
    public Button optionC;
    public Button optionD;

    public GameObject Right;
    public GameObject Wrong;
    // The correct option
    public Text Score;
    public Button correctOption;
    // int number = 0;

    // Start is called before the first frame update
    void Start()
    {
        Right.SetActive(false);
        Wrong.SetActive(false);
        // SceneManager.sceneLoaded += OnSceneLoaded;

        // Hook quiz option events
        optionA.onClick.AddListener(() => CheckAnswer(optionA));
        optionB.onClick.AddListener(() => CheckAnswer(optionB));
        optionC.onClick.AddListener(() => CheckAnswer(optionC));
        optionD.onClick.AddListener(() => CheckAnswer(optionD));
    }
    //     void OnSceneLoaded(Scene loadedScene, LoadSceneMode mode)
    // {
    //     // This method will be called when a scene finishes loading
    //     // Debug.Log("Scene loaded: " + loadedScene.name);
    //     // Right.SetActive(true);
    //     // Perform additional actions or setup related to the newly loaded scene
    //     // For example, spawn player, initialize UI, etc.
    // }
    // void OnDestroy()
    // {
    //     // Unsubscribe from the sceneLoaded event when this object is destroyed
    //     SceneManager.sceneLoaded -= OnSceneLoaded;
    // }
    // public void increcount(ref int value)
    // {
    //     value = value + 1;
    //     return;
    // }

    // Check the answer for quiz options
    public void CheckAnswer(Button selectedOption)
    {
        if (selectedOption == correctOption)
        {

            Right.SetActive(true);
            Wrong.SetActive(false);
            //ScoreIncrement(number);
            // Score.text = number.ToString();
            selectedOption.GetComponent<Image>().color = Color.green;
        }
        else
        {
            Wrong.SetActive(true);
            Right.SetActive(false);
            selectedOption.GetComponent<Image>().color = Color.red;
        }
    }
}