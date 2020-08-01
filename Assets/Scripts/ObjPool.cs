using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjPool : MonoBehaviour
{
    [SerializeField] List<GameObject> bugsContainer = new List<GameObject>();     //Bugs container for ObjectPool
    [SerializeField] GameObject bugPrefab;  //Can be change to a list for different Bugs
    [SerializeField] int bugStartAmount = 5;    //Start amount of the bug generator
    [SerializeField] Camera mainCamera;     //Cache main camera for save memory

    private Vector3 bugSpawnPos;

    private void Start()
    {
        BugGenerator();   
    }

    void BugGenerator()
    {
        for(var i = 0; i < bugStartAmount; i++)
        {
            GameObject bug = Instantiate(bugPrefab, BugSpawnRandomPos(), transform.rotation);
            bugsContainer.Add(bug); //add instantiate bugs to the bug container for start the objpool
        }
    }

    Vector3 BugSpawnRandomPos()
    {
        var screenY = Screen.height;
        var screenX = Screen.width;
        var ScreenSize = mainCamera.ScreenToWorldPoint(new Vector3(screenX, screenY, 0)); //Convert our camera view to screensize for bugs spawns positions
        var randomX = Random.Range(-ScreenSize.x + 2, ScreenSize.x - 2);
        var randomY = Random.Range(-ScreenSize.y + 2, ScreenSize.y - 2);    //RandomPosition for X and Y screenSize
        bugSpawnPos = new Vector3(randomX, randomY); //When instantiate the bug will take a random value from the screen size
        return bugSpawnPos;
    }
}
