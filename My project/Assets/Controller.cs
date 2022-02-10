using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public int lives = 10;

    float speed = 10f;
    double spd = 10f;

    string name = "player";

    bool isActive = true;

    char c = 'A';

    public int[] list = { 1, 2, 3, 4, 5 };

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start");
    }

    void Enable()
    {
        Debug.Log("Enable");
    }

    void Awake()
    {
        Debug.Log("Awake");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Update");

        if (isActive)
        {
            Debug.Log("isActive " + isActive.ToString());
        }
        else
        {
            Debug.Log("no active");
        }
        {
            switch (lives)
            {
                case 1:
                    Debug.Log("Lives is " + lives.ToString());
                    break;
                case 2:
                    Debug.Log("Lives is " + lives.ToString());
                    break;
                default:
                    Debug.Log("Default Lives is " + lives.ToString());
                    break;
            }
            while (isActive)
            {

                void Awake()
                {
                    for (int i = 0; i < list.Length; i++)
                    {
                        Debug.Log(list[i]);
                    }
                    foreach (int i in list)
                    {
                        Debug.Log("i is " + i.ToString());
                    }
                }
            }
        }
    }
}