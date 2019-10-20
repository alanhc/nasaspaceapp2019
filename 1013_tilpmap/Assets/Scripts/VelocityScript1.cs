using UnityEngine;
using System.Collections;

public class VelocityScript : MonoBehaviour {
	    public float startSpeed =50;
	    // Use this for initialization
	    void Start () {
		        Rigidbody rigidbody = GetComponent<Rigidbody> ();
		// 給實體一個向量的速度
		        rigidbody.velocity = new Vector3 (startSpeed, 0, startSpeed);
		    }
} 
