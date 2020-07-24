using UnityEngine;

public class MouseLook : MonoBehaviour
{
    public void Update()
    {
        var playerScreenPoint = Camera.main.WorldToScreenPoint(transform.position);

        if (Input.mousePosition.x - playerScreenPoint.x > 0)
        {
            transform.rotation = Quaternion.Euler(0, 180, 0);
        }
        else
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }

    }
}