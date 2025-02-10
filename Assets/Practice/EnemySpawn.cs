using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public Transform enemyPos;
    public float startTime, spawnTime;
    public GameObject enemys;
    public float enemyHp, maxHp, hp_p, hp_recover;
    public GameObject hpreal;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        startTime += Time.deltaTime;
        if (startTime > spawnTime)
        {
            Instantiate(enemys, enemyPos.position, enemyPos.rotation);
            startTime = 0;
            spawnTime = Random.Range(1.0f, 3.0f);
            enemyHp += hp_recover;
            updateHp();
        }
        if (enemyHp > maxHp)
        {
            enemyHp = maxHp;
            updateHp();
        }
        if (enemyHp <= 0 )
        {
            //Object.FindObjectOfType<GameManager>.addScorePoint(10);
            Destroy(gameObject);
        }
    }

    public void onHit(float power)
    {
        enemyHp -= power;
        updateHp();
    }
    void updateHp()
    {
        hp_p = enemyHp / maxHp;
        Debug.Log("¦å¶q%:" + hp_p);
        hpreal.GetComponent<RectTransform>().localScale = new Vector3(hp_p, 1, 1);
    }
}
