using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    [SerializeField] float timeToCompleteQuestion = 30f;
    [SerializeField] float timeToShowCorrectAnswer = 10f;
    float timerValue = 0;
    public float fillFraction;
    public bool isAnsweringQuestion = false;
    public bool loadNextQuestion = true;

    void Update()
    {
        UpdateTimer();
    }

    void UpdateTimer(){
        timerValue -= Time.deltaTime;
        if(timerValue > 0){
            if(isAnsweringQuestion){
                fillFraction = timerValue / timeToCompleteQuestion;
            } else {
                fillFraction = timerValue / timeToShowCorrectAnswer;
            }
        } else {
            if (isAnsweringQuestion){
                timerValue = timeToShowCorrectAnswer;
                isAnsweringQuestion = false;
            } else {
                timerValue = timeToCompleteQuestion;
                isAnsweringQuestion = true;
                loadNextQuestion = true;
            }
        } 
    }

    public void CancelTimer(){
        timerValue = 0;
    }
}
