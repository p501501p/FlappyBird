using UnityEngine;
using UnityEngine.UI;

public class PipeScript : MonoBehaviour
{
    public float moveSpeed = 10f;
    public float deadZone = -45;

    private int lastScoreCheckpoint = 0;
    public LogicScript logicScript; 

    void Start()
    {
        logicScript = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    void Update()
    {
        bool IsDead = logicScript.Dead;
    
        transform.position += Vector3.left * moveSpeed * Time.deltaTime;

    
        if (transform.position.x < deadZone)
        {
            Destroy(gameObject);
        }

   
        int currentScore = logicScript.playerScore;
        float globalPipeSpeed1 = logicScript.globalPipeSpeed;
        if (currentScore >= lastScoreCheckpoint + 3 && moveSpeed <= 28)
        {
            moveSpeed += globalPipeSpeed1; // เพิ่มความเร็ว
            lastScoreCheckpoint = currentScore; // อัปเดตจุด checkpoint
        }
        if (IsDead == true)
        {
            moveSpeed = 0;
        }
    }
}