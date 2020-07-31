using System.Collections;
using System.Collections.Generic;
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
    [SerializeField]
    private
       int scoreVal = 0;
       int velocity = 0;
       bool allowDuplicates = true;

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
    void SetScore(int val)
    {
        scoreVal = val;
    }
    void SetVelocity(int val)
    {
        velocity = val;
    }
    void SetAllDupps(bool val)
    {
        allowDuplicates = val;
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
