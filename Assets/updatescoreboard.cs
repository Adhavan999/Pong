using UnityEngine;
using UnityEngine.UI;

public class updatescoreboard : MonoBehaviour {

    public int scores =0;

    private void Start()
    {
        GetComponent<Text>().text = "0";
    }
    public void updateboard()
    {
        scores++;
        GetComponent<Text>().text = scores.ToString();
    }
}
