using UnityEngine;

public class changeCamera : MonoBehaviour
{
    public GameManager gm;
    public int canNum;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            gm.changeCamPos(canNum);
        }
    }
}
