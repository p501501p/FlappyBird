using UnityEngine;
using System.Threading.Tasks;

public class BirdScript : MonoBehaviour
{
    public Animator animator;
    public Rigidbody2D myRigibody;
    public Collider2D Body;
    public LogicScript logicScript;
    public bool birdIsAlive = true;
    public int jumpower = 5;

    void Start()
    {
        logicScript = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    void Update()
    {
        if ((Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.Mouse0)) && birdIsAlive)
        {
            myRigibody.linearVelocity = Vector2.up * jumpower;
            animator.SetBool("ISFlying", true);
        }
        else
        {
            animator.SetBool("ISFlying", false);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision2D)
    {
        logicScript.gameOver();
        birdIsAlive = false;
        DisableColliderAfterDelay(); 
    }

    private async void DisableColliderAfterDelay()
    {
        await Task.Delay(200);
        Body.enabled = false;
    }
}
