using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleTree : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject applePrefav;
    public float speed = 1f;
    public float leftAndRightEdge = 10f;
    public float chanceToChangeDirections = 0.05f;
    public float secondsBetweenAppleDrops = 3f;


    void Start()
    {
        Invoke("DropApple", secondsBetweenAppleDrops);
    }

    private void DropApple()
    {
        GameObject apple = Instantiate(applePrefav);
        Vector3 orig_pos = this.transform.position;
        orig_pos.y += -1f;
        apple.transform.position = orig_pos;
        Invoke("DropApple", secondsBetweenAppleDrops);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;
        pos.x += speed * Time.deltaTime;
        transform.position = pos;
        if (pos.x < -leftAndRightEdge)
        {
            speed = Mathf.Abs(speed);
        }
        else if(pos.x>leftAndRightEdge)
        {
            speed = Mathf.Abs(speed);
        }
        else if (Random.value < chanceToChangeDirections)
        { //a
            speed *= -1; // Change direction 11 b
        }
    }

    private void FixedUpdate()
    {
        if (Random.value < chanceToChangeDirections)
        {
            speed *= -1;
        }
    }
}
