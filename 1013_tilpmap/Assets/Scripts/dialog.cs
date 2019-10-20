using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class dialog : MonoBehaviour
{
    // Start is called before the first frame update
    

    // Update is called once per frame
    void Update()
    {
        //int i =GameObject.FindWithTag("6").GetComponent<Point>().index;

        if (Input.GetKeyDown("space"))
        {
            int i = Random.Range(0, 28);
            if (i == 1 || i == 8 || i == 15 || i == 22)
            {
                GetComponent<Text>().text = "地震來了塊陶阿~";
            }
            else if (
                i == 4 || i == 5 || i == 10 || i == 12 || i == 13 || i == 17 ||
                i == 19 || i == 20 || i == 23 || i == 25 || i == 27)
            {
                GetComponent<Text>().text = "問題一、大洋洲的島國受到地球環境變遷的影響，已面臨國土淹没的危機，甚至部分國家已開始遷移至他處。造成上述情形的 主要原因為水資源汙染？";
            }
            else
            {
                switch (i)
                {
                    case 2:
                        GetComponent<Text>().text = "[公投]是否要蓋南屯垃圾焚化廠";
                        break;
                    case 3:
                        GetComponent<Text>().text = "[公投]是否要蓋新桃燃氣電廠";
                        break;
                    case 6:
                        GetComponent<Text>().text = "[公投]是否要蓋核能電廠";
                        break;
                    case 9:
                        GetComponent<Text>().text = "[公投]是否要蓋和平燃煤電廠";
                        break;
                    case 11:
                        GetComponent<Text>().text = "[公投]是否要垃圾焚化爐";
                        break;
                    case 16:
                        GetComponent<Text>().text = "[公投]補助青年返家種田?";
                        break;
                    case 18:
                        GetComponent<Text>().text = "[公投]是否要蓋協和燃油發電廠";
                        break;
                    case 24:
                        GetComponent<Text>().text = "[公投]是否要蓋海湖燃氣發電廠";
                        break;
                    case 26:
                        GetComponent<Text>().text = "[公投]是否要蓋城西垃圾焚化廠";
                        break;

                }
            }

        }
    }
        
}
