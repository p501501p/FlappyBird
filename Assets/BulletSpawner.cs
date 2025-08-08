using UnityEngine;

public class BulletSpawner : MonoBehaviour
{
   public GameObject pipe;
    public float spawnTime = 15;
    private float timer = 0;
    public float heightOfSet = 10;
    public LogicScript logicScript;
    private int lastScoreCheckpoint = 0;
    void Start()
    {
        logicScript = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame


    void Update()
    {
        bool IsDead = logicScript.Dead;
        int currentScore = logicScript.playerScore;
        if (timer < spawnTime)
        {
            timer += Time.deltaTime;
        }
        else
        {
            float minY = 7;
            float maxY = -7;
            Instantiate(pipe, new Vector3(transform.position.x, Random.Range(minY, maxY), 0), transform.rotation);

            timer = 0;

        }
        if (currentScore >= lastScoreCheckpoint + 10 && spawnTime >= 10)
        {
            spawnTime -= 0.1f;
            lastScoreCheckpoint = currentScore;
        }
        if (IsDead == true)
        {
            spawnTime = 100000000000000;
        }
}
}
