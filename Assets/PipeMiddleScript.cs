using UnityEngine;

public class PipeMiddleScript : MonoBehaviour
{

    public LogicScript logicScript;    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        logicScript = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

       private void OnTriggerEnter2D(Collider2D other)
    {
            logicScript.addScore();
    }

    // Update is called once per frame
    void Update()
{


}
    }
    
