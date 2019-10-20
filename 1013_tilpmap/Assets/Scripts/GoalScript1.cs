using UnityEngine;
using System.Collections;

public class GoalScript : MonoBehaviour {
	// 有物件碰撞進來時，執行下面程式
	    void OnTriggerEnter (Collider collider) {
		// 取得碰撞的物件
		        GameObject collidedWith = collider.gameObject;
		        // 如果兩者的 Tag 一樣，關燈並且將該球銷毀
		        if (collidedWith.tag == gameObject.tag) {
			            GetComponent<Light>().intensity = 0;
			            Destroy (collidedWith);
			        }
		    }
} 
