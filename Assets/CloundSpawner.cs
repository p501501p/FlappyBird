using UnityEngine;

public class CloundSpawner : MonoBehaviour
{

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject pipe;
    public float spawnTime = 5;
    private float timer = 0;
    public float heightOfSet = 10;
    void Start()
    {
        
    }

    // Update is called once per frame


void Update()
{
    if(timer < spawnTime){
        timer += Time.deltaTime;
    }else{
            float minY = -10;
            float maxY = -9;
            Instantiate(pipe, new Vector3(transform.position.x, Random.Range(minY,maxY), 0), transform.rotation);

            timer = 0;
    }
}
}
