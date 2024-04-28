using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    /*[SerializeField] Transform shootPoint;
    [SerializeField] private GameObject target;
    [SerializeField] private Rigidbody2D bulletPrefab;
    
    
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Debug.DrawRay(ray.origin, ray.direction * 10f, Color.magenta, 10f);

            RaycastHit2D hit = Physics2D.GetRayIntersection(ray, Mathf.Infinity);
            if (hit.collider != null)
            {
                target.transform.position = new Vector2(hit.point.x, hit.point.y);
                Debug.Log($"hit point = ({hit.point.x}, {hit.point})");

                
                Vector2 projectile = CalculateProjectileVelocity(shootPoint.position, hit.point, 1f);
                Rigidbody2D fire = Instantiate(bulletPrefab, shootPoint.position, Quaternion.identity);
                fire.velocity = projectile;
            }
        }
    }

    Vector2 CalculateProjectileVelocity(Vector2 origin, Vector2 target, float t)
    {
        Vector2 distance = target - origin;
        float distX = distance.x;
        float distY = distance.y;

        float velocityX = distX / t;
        float velocityY = distY / t+0.5f *Mathf.Abs(Physics2D.gravity.y) *t;
        Vector2 result = new Vector2(velocityX, velocityY);
        return result;
    }*/
}
