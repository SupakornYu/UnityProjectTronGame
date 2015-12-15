using UnityEngine;
using System.Collections;

public class enemyController : MonoBehaviour
{
    
    NavMeshAgent enemyAgent;

    Transform player;

    Animator enemyAnimator;

    float speed;

    void Start()
    {
        enemyAgent = GetComponent<NavMeshAgent>();
        enemyAnimator = GetComponent<Animator>();
        player = GameObject.FindGameObjectWithTag("Player").transform;
        enemyAgent.speed = 0.0f;
    }

    void Update()
    {
        
        if (player != null)
        {
            enemyAgent.transform.LookAt(player.position);

            Vector3 location = transform.position - player.position;

            if (location.magnitude <= 1.5)
            {
                speed = 0.0f;
                enemyAgent.speed = 0.0f;
                enemyAgent.Stop();
                Debug.Log("less than stop");
            }
            else if (location.magnitude <= 15.0)
            {
                speed = 1.0f;
                enemyAgent.speed = 1.0f;
                //enemyAgent.Resume();
                Debug.Log("less than 15");
                
            }
            else {
                speed = 1.0f;
                //enemyAgent.Resume();
                enemyAgent.speed = 1.0f;
            }

            enemyAnimator.SetFloat("speed", speed);

            enemyAgent.SetDestination(player.position);

        }
        
    }

    void OnTriggerEnter(Collider obj)
    {
        
        if (obj.gameObject.CompareTag("EnemyCheckCeiling"))
        {
            enemyAnimator.SetBool("crouch", true);
        }

        //Destroy(other.gameObject);
    }

    void OnTriggerExit(Collider obj)
    {
        if (obj.gameObject.CompareTag("EnemyCheckCeiling"))
        {
            enemyAnimator.SetBool("crouch", false);
        }
        // Destroy everything that leaves the trigger
        //Destroy(other.gameObject);
    }

}
