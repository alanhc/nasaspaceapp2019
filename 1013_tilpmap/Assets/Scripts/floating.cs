using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class floating : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.name== "people") transform.position = new Vector3(transform.position.x, 20+GameObject.FindWithTag("water").transform.position.y, transform.position.z);
        else transform.position = new Vector3(transform.position.x, GameObject.FindWithTag("water").transform.position.y, transform.position.z);
        print(gameObject.name);


    }
}
