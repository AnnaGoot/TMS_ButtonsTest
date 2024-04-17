using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour
{
    Transform target;
    NavMeshAgent agent;
    public float LookRadius;

    public Animator animator;


    private void Start()
    {
        animator = GetComponent<Animator>();
        agent = GetComponent<NavMeshAgent>();
        target = PlayerTarget.instance.player.transform;
    }

    private void Update()
    {
        float distance = Vector3.Distance(target.position, transform.position);
        if (distance <= LookRadius)
        {
            animator.SetBool("isRunning", true);
            agent.SetDestination(target.position);
            if (distance <= agent.stoppingDistance)
            {
                animator.SetBool("isFight", true);
                animator.SetBool("isRunning", false);
                LookTarget();
            }
            else
            {
                animator.SetBool("isFight", false);
            }
        }
        else
        {
            animator.SetBool("isRunning", false);
        }
    }

    void LookTarget()
    {
        Vector3 direction = (target.position - transform.position).normalized;
        Quaternion lookRotation = Quaternion.LookRotation(new Vector3(direction.x, 0, direction.z));
        transform.rotation = (Quaternion.Slerp(transform.rotation, lookRotation, Time.deltaTime * 5f));

    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, LookRadius);
    }
}
