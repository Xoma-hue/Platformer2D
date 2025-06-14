using UnityEngine;

public class Enemy : MonoBehaviour
{
  public Transform pointA;
  public Transform pointB;
  public float speed = 2f;
  public int damage = 1; 
  private Transform targetPoint;

  void Start()
  {
    targetPoint = pointB;
  }

  void Update()
  {
    // Рух до цільової точки
    transform.position = Vector2.MoveTowards(transform.position, targetPoint.position, speed * Time.deltaTime);

    // Якщо дістався — змінити ціль
    if (Vector2.Distance(transform.position, targetPoint.position) < 0.1f)
    {
      if (targetPoint == pointA)
        targetPoint = pointB;
      else
        targetPoint = pointA;
    }
  }
  private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            // Якщо є скрипт здоров'я у гравця — нанести шкоду
            PlayerHealth health = collision.GetComponent<PlayerHealth>();
            if (health != null)
            {
                health.TakeDamage(damage);
            }
        }
    }
}
