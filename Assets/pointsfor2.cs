using System.Collections;
using UnityEngine;

public class pointsfor2 : MonoBehaviour
{
    public GameObject board;
    public GameObject ball;

    IEnumerator waitforspawn()
    {
        yield return new WaitForSeconds(1.5f);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject killball = collision.gameObject;
        Destroy(killball);
        StartCoroutine(waitforspawn());
        Instantiate(ball);
        board.GetComponent<scores>().p2points++;
        
    }
}

