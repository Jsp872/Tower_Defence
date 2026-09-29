using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPath : MonoBehaviour
{
    [SerializeField] List <Transform> waypoints;
    [SerializeField] Nexus nexus;

    public IEnumerator FollowPath(Enemy enemy)
    {
        for (int i = 0; i < waypoints.Count; i++)
        {
            enemy.transform.position = waypoints[i].position;
            Debug.Log(enemy.enemyData.speed);
            yield return new WaitForSeconds(enemy.enemyData.speed);
        }
    }
}
