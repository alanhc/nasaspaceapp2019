using UnityEngine;
using System.Collections;

public class GreenFall : MonoBehaviour {
    public GameObject green;
	void Start () {
        //green = GameObject.FindGameObjectWithTag("GreenMon");
        //green = GameObject.Find("Green");
	}
	
	void Update () {
        if (green!=null && green.transform.position.y < -10)
        {
            GetComponent<TextMesh>().text = "XXX 推落綠怪！紅怪追 XXX ！";
            GameObject.Destroy(green);
            GameObject.Find("GameController").GetComponent<GameControl>().state = 1;
        }
	}
}
