﻿using Ink.Runtime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Dialogos2 : MonoBehaviour
{
    public TextAsset inkJSON;
    private Story story;
    public Text textPrefab;
    public Button buttonPrefab;



    // Start is called before the first frame update
    void Start()
    {
        story = new Story(inkJSON.text);
        refreshUI();
    }
    void refreshUI()
    {
        eraseUI();
        Text storyText = Instantiate(textPrefab) as Text;
        storyText.text = loadStoryChunk();
        storyText.transform.SetParent(this.transform, false);

        foreach (Choice choice in story.currentChoices)
        {
            Button choiceButton = Instantiate(buttonPrefab) as Button;
            Text choiceText = choiceButton.GetComponentInChildren<Text>();
            choiceText.text = choice.text;
            string actual = choiceText.text.ToString();
            Debug.Log(actual + " prueba");
            choiceButton.transform.SetParent(this.transform, false);

            choiceButton.onClick.AddListener(delegate {
                if (actual == "Comenzar")
                {
                    InteraccionesRobot.walk = true;
                    Debug.Log(InteraccionesRobot.walk);
                }
                else
                {
                    chooseStoryChoice(choice);
                }

            });

        }
    }
    void eraseUI()
    {
        for (int i = 0; i < this.transform.childCount; i++)
        {
            Destroy(this.transform.GetChild(i).gameObject);
        }
    }
    void chooseStoryChoice(Choice choice)
    {
        story.ChooseChoiceIndex(choice.index);
        refreshUI();
    }
    // Update is called once per frame
    void Update()
    {

    }
    string loadStoryChunk()
    {
        string text = "";
        if (story.canContinue)
        {
            text = story.ContinueMaximally();
        }

        return text;

    }
}
