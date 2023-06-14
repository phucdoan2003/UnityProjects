using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorekeeper : MonoBehaviour
{
    int correctAnswers = 0;
    int questionsSeen = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public int GetCorrectAnswers(){
        return correctAnswers;
    }

    public void IncrementCorrectAnswer(){
        correctAnswers++;
    }

    public int GetQuestionsSeen(){
        return questionsSeen;
    }

    public void IncrementQuestionsSeen(){
        questionsSeen++;
    }

    public int CalculateScore(){
        return Mathf.RoundToInt((float)correctAnswers/ (float)questionsSeen *100);
    }

}
