using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Red : MonoBehaviour {
    public GameObject pc;
	void Update () {
        if (GameObject.Find("GameController").GetComponent<GameControl>().state==1)
        {
            Vector3 movement= (pc.transform.position-transform.position).normalized*Time.deltaTime;
            transform.position = transform.position + movement;

        }
	}
    private void OnCollisionEnter(Collision info)
    {
        if (info.gameObject.name == "PC")
        {
            SceneManager.LoadScene("Fail");
        }
    }
}
