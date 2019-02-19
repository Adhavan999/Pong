using UnityEngine;

public class playercontroller : MonoBehaviour {

    public float movespeed = 1f;
    public bool isplayer1 = true;
    float bounded;

    private void Start()
    {
        Vector3 newpos = new Vector3(transform.position.x, 0, transform.position.z);
        transform.SetPositionAndRotation(newpos, transform.rotation);

    }

    void Update ()
    {
        if (isplayer1)
        {
            if (Input.GetKey(KeyCode.W))
            {

                transform.Translate(0f, movespeed * Time.deltaTime, 0f);
            }
            else if (Input.GetKey(KeyCode.S))
            {
                transform.Translate(0f, -movespeed * Time.deltaTime, 0f);
            }
        }
        else
        {
            if (Input.GetKey(KeyCode.UpArrow))
            {
                transform.Translate(0f, movespeed * Time.deltaTime, 0f);
            }
            else if (Input.GetKey(KeyCode.DownArrow))
            {
                transform.Translate(0f, -movespeed * Time.deltaTime, 0f);
            }
        }
        bounded = Mathf.Clamp(transform.position.y, -4.1f, 4.2f);
        Vector3 newpos = new Vector3(transform.position.x, bounded, transform.position.z);
        transform.SetPositionAndRotation(newpos,transform.rotation);
        
    }
}
