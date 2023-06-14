using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Endscreen : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI finalScoreText;
    Scorekeeper scorekeeper;
     void Awake() 
    {
        scorekeeper = FindObjectOfType<Scorekeeper>();
    }

    public void ShowFinalScore(){
        finalScoreText.text = "Congratulations! \n Your final score: " + scorekeeper.CalculateScore() + "%";
    }

}
