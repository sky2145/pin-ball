using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class BallControler : MonoBehaviour
{
    //得点を表示するテキスト
    private GameObject ScoreText1;
    //得点を格納する変数
    int score = 0;
    //ボールが見える可能性のあるz軸の最大値
    private float visiblePosZ = -6.5f;
    //ゲームオーバを表示するテキスト
    private GameObject GameoverText;
    // Use this for initialization
    void Start()
    {
        //シーン中のGameOverTextオブジェクトを取得
        this.GameoverText = GameObject.Find("GameOverText");
        this.ScoreText1 = GameObject.Find("ScoreText1");

    }
    // Update is called once per frame
    void Update()
    {
        //ボールが画面外に出た場合
        if (this.transform.position.z < this.visiblePosZ)
        {
            //GameoverTextにゲームオーバを表示
            this.GameoverText.GetComponent<Text>().text = "Game Over";
        }
    }
    //衝突時に呼ばれる関数
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "SmallStarTag")
        {
            score += 10;
            this.ScoreText1.GetComponent<Text>().text = "現在の点数は " + score.ToString() + " 点です｡";
            Debug.Log("現在の点数は " + score.ToString() + " 点です。TODO： 点数を画面に表示する");
        }
        else if (other.gameObject.tag == "LargeStarTag")
        {
            score += 20;
            this.ScoreText1.GetComponent<Text>().text = "現在の点数は " + score.ToString() + " 点です。";
            Debug.Log("現在の点数は " + score.ToString() + " 点です。TODO： 点数を画面に表示する");

        }
        else if (other.gameObject.tag == "SmallCloudTag" || tag == "LargeCloudTag")
        {
            score += 30;
            this.ScoreText1.GetComponent<Text>().text = "現在の点数は " + score.ToString() + " 点です。";
            Debug.Log("現在の点数は " + score.ToString() + " 点です。TODO： 点数を画面に表示する");
        }
    }
}