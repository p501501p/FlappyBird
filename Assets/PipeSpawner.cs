using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject pipe;
    public float spawnTime = 5;
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
            float minY = 28;
            float maxY = 14;
            Instantiate(pipe, new Vector3(transform.position.x, Random.Range(minY, maxY), 0), transform.rotation);

            timer = 0;

        }
        if (currentScore >= lastScoreCheckpoint + 10 && spawnTime >= 2)
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
