using UnityEngine;

public class BulletSript : MonoBehaviour
{
    public float moveSpeed = 75f;
    public float deadZone = -45;

    private int lastScoreCheckpoint = 0;
    public LogicScript logicScript; // อ้างอิงถึง LogicScript ที่เก็บคะแนน

    void Start()
    {
        logicScript = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    void Update()
    {
        bool IsDead = logicScript.Dead;
        // เคลื่อนที่ท่อ
        transform.position += Vector3.left * moveSpeed * Time.deltaTime;

        // ทำลายเมื่อเลย Dead Zone
        if (transform.position.x < deadZone)
        {
            Destroy(gameObject);
        }

        // เช็คคะแนน และเพิ่มความเร็วทุก ๆ 10 คะแนน
        int currentScore = logicScript.playerScore;
        float globalPipeSpeed1 = logicScript.globalPipeSpeed;
        if (currentScore >= lastScoreCheckpoint + 3 && moveSpeed <= 100)
        {
            moveSpeed += globalPipeSpeed1; // เพิ่มความเร็ว
            lastScoreCheckpoint = currentScore; // อัปเดตจุด checkpoint
        }
    }
}
