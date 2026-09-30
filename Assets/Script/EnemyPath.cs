using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class EnemyPath : MonoBehaviour
{
    [SerializeField] List<Transform> waypoints;
    [SerializeField] Nexus nexus;
    [SerializeField] float randomRadius = 1f;

    public IEnumerator FollowPath(Enemy enemy)
    {
        for (int i = 0; i < waypoints.Count; i++)
        {
            Vector2 randomOffset = Random.insideUnitCircle * randomRadius;
            Vector3 target = waypoints[i].position + new Vector3(randomOffset.x, randomOffset.y, 0);

            while (Vector3.Distance(enemy.transform.position, target) > 0.01f)
            {
                enemy.transform.position = Vector3.MoveTowards(enemy.transform.position,target,enemy.enemyData.speed * Time.deltaTime);

                yield return null;
            }
        }
        while (Vector3.Distance(enemy.transform.position, nexus.gameObject.transform.position) > 0.01f)
        {
            enemy.transform.position = Vector3.MoveTowards(enemy.transform.position, nexus.gameObject.transform.position, enemy.enemyData.speed * Time.deltaTime);

            yield return null;
        }

        Destroy(enemy.gameObject);
    }
}