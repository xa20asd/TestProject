using UnityEngine;

public class Item : MonoBehaviour
{
    public bool isHeal, isPoint, isFire, isThreeFire, isShotgunFire;
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
            if (isHeal) 
            {
                collision.gameObject.GetComponent<Player2D>().addHp();
                Debug.Log("«ì´_ª±®a¦å¶q");
                Destroy(gameObject);
            }
            if (isPoint) 
            {
                //Object.FindObjectOfType<GameManager>.addScorePoint(10);
                Destroy(gameObject);
            }
            if (isFire)
            {
                collision.gameObject.GetComponent<Player2D>().iscanfire();
                Destroy(gameObject);
            }
            if (isThreeFire)
            {
                collision.gameObject.GetComponent<Player2D>().isThreeFire();
                Destroy(gameObject);
            }
            if (isShotgunFire)
            {
                collision.gameObject.GetComponent<Player2D>().isShotgun();
                Destroy(gameObject);
            }

        }
    }
}
