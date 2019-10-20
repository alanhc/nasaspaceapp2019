using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Point : MonoBehaviour
{
    GameObject person;
    
    
    public int[] playerX = {
        0,0,0,0,0,0,0,0,
        30,60,90,120,150,180,210,
        210,210,210,210,210,210,210,
        180,150,120,90,60,30,
        180,150,120,90,60,30
    };
    public int[] playerZ = {
        0,30,60,90,120,150,180,210,
        210,210,210,210,210,210,210,
        180,150,120,90,60,30,0,
        0,0,0,0,0,0,0,0
    };
    
    public static int i;
    
    int throw_dice;
    void Start()
    {
        person = GameObject.FindWithTag("person");
        
        throw_dice = 0;
    }

    //public int index;
    void Update()
    {
        
        if (Input.GetKeyDown("space"))
        {
            throw_dice = 1;
            print("i is"+i);
        }
       //index = i;
}
    public int pt=0;
    static float rise_h = 5;

    void OnTriggerEnter(Collider other)
    {
        if (throw_dice == 1) {
            print("down");
            pt = int.Parse(gameObject.tag);
            i = i+pt;

            print(i + ","+gameObject.tag + "\n");
            
            throw_dice = 0;
            if (i >= 28) i = i - 28;
            person.transform.position = (new Vector3(playerX[i], 2, playerZ[i]));
            GameObject.FindWithTag("water").transform.position = new Vector3(GameObject.FindWithTag("water").transform.position.x, rise_h, GameObject.FindWithTag("water").transform.position.z);
            
        }
        
    }
}
