using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    public GameObject obj;
    public int gridSize = 5;

    Vector3 position;
    float spacing = 1f;

    private void Start()
    {
        position = new Vector3(-5f, 0f, 0f);


        func(); 
    }

    public void func()
    {
        if (obj == null) return;

        for (int j = 0; j < 4; j++)
        {
            for (int i = 0; i <= 8; i++)
            {
                Instantiate(obj, position, Quaternion.identity);

                position.x += i;
                position.y += 2;

                Debug.Log(i);
            }
        }
    }
}