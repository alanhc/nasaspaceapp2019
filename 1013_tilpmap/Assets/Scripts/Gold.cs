using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Gold : MonoBehaviour {
    private void OnCollisionEnter(Collision collision)
    {
        if (GameObject.Find("GameController").GetComponent<GameControl>().state == 1)
        {
            if (collision.gameObject.name == "PC")
            {
                SceneManager.LoadScene("Finish");
            }
        }
    }
}
