using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Basket : MonoBehaviour
{

    [Header("Set Dynamically")]
    public Text scoreGT;

    // Start is called before the first frame update
    void Start()
    {
        GameObject scorGO = GameObject.Find("ScoreCounter");
        scoreGT = scorGO.GetComponent<Text>();
        scoreGT.text = "0";
    }

    // Update is called once per frame
    void Update()
    {

        // Получить текущие координаты указателя мыши на экране из Input

        Vector3 mousePos2D = Input.mousePosition; // a
        mousePos2D.z = -Camera.main.transform.position.z; // b
        Vector3 mousePos3D = Camera.main.ScreenToWorldPoint(mousePos2D); // c
        Vector3 pos = this.transform.position;
        pos.x = mousePos3D.x;
        this.transform.position = pos;

    }



    void OnCollisionEnter(Collision collision)
    {

        GameObject collidedWith = collision.gameObject;
        if (collidedWith.tag == "Apple")
        {
            Destroy(collidedWith);

            int score = int.Parse(scoreGT.text);
            score += 100;
            scoreGT.text = score.ToString();

            if (score > HighScore.score)
            {
                HighScore.score = score;
            }
        }

    }
}
