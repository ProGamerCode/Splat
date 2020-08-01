using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchTapKill : MonoBehaviour
{ 
    private void BugTap()
    {
        gameObject.SetActive(false); //When tap the bug will deactivate
        GameObject.FindObjectOfType<BugObj>().SetScore();
    }

    void OnMouseDown()
    {
        BugTap();
    }
}
