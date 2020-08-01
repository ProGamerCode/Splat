using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class BugObj : MonoBehaviour
{
    //this allows for assignment in editor 
    //in the edited words of unitys documentation
    //*****************************************************/
    /*This/'these' field/s gets serialized even though it is(they are) private*/
    /*because it has the SerializeField attribute applied.*/
    //*****************************************************/
    //likely to be removed in favor of getter and setter 
    //functions after testing is complete
    
    private int scoreVal = 0;
    private int velocity = 0;
    private bool allowDuplicates = true;
    private string sct = "Score ";     //cache string value for save memory

    [SerializeField] TextMeshProUGUI scoreText;

    //getter and setter functions
    int GetScore()
    {
        return scoreVal;
    }
    int GetVelocity()
    {
        return velocity;
    }
    bool GetAllowDupps()
    {
        return allowDuplicates;
    }
    public void SetScore()
    {
        scoreVal++;
    }
    void SetVelocity(int val)
    {
        velocity = val;
    }
    void SetAllDupps(bool val)
    {
        allowDuplicates = val;
    }

    void Start()
    {
        scoreText.text = sct + GetScore().ToString();
    }

    void LateUpdate()
    {
        scoreText.text = sct + GetScore().ToString();
    }
}
