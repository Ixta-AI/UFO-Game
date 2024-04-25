using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using TMPro;// Text Mesh Pro namespace added to access the unity libraries for UI

public class ScoreManager : MonoBehaviour
{
    public int score; // Keep score value (empty until assigned)

    public TextMeshProUGUI scoreText;// Visual text element to be modified

    public void IncreaseScore(int amount) // Calling this method increases score by a predetermined amount set in score variable
    {
        score += amount; // initial score(10) is equal to initial score + amount(15)  
        UpdateScoreText();//Calls method/Function
    }

    public void DecreaseScore(int amount) // Calling this method decreases score by a predetermined amount set in score variable
    {
        score -= amount;
        UpdateScoreText();
    }

    public void UpdateScoreText() // This method updates score in the Heads Up Display (HUD) UI text
    {
        scoreText.text = "Score: " + score;//Access scoreText text and assign it new calculated score. The "" is text while score is an integer
    }
}
//Public = can be accessed from other scripts or class' 
//Void = Type of function/Method that does not return any values
//(argument var) = Local var tied to method it is passed into