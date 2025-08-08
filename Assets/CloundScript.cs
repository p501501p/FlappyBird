using UnityEngine;

public class CloundScript : MonoBehaviour
{
    public float moveSpeed = 5;
    public float deadZone = -45;


    void Start()
    {
    }

    void Update()
    {
        // เคลื่อนที่ท่อ
        transform.position += Vector3.left * moveSpeed * Time.deltaTime;

        // ทำลายเมื่อเลย Dead Zone
        if (transform.position.x < deadZone)
            Destroy(gameObject);

        // เช็คคะแนน และเพิ่มความเร็วทุก ๆ 10 คะแนน
        
    }
}

