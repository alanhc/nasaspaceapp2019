using UnityEngine;
using System.Collections;

public class GameControlScript : MonoBehaviour {
	    public GameObject blueBall, greenBall, redBall, orangeBall;
	    private bool isGameOver = true;    

	    // Update is called once per frame
	    void Update () {
		        // 如果所有的球都已經不存在(被銷毀)，則遊戲結束
		        isGameOver = !blueBall && !greenBall && !redBall && !orangeBall;        
		    }

	    void OnGUI() {
		        // 遊戲結束時，show 訊息
		        if(isGameOver) {
			            Rect rect = new Rect (Screen.width / 2 - 100, Screen.height / 2 - 50, 200, 75);
			            GUI.Box (rect, "Game Over");

			            Rect rect2 = new Rect (Screen.width / 2 - 30, Screen.height / 2 - 25, 60, 50);
			            GUI.Label (rect2, "Good Job!");
			        }
		    }
} 
