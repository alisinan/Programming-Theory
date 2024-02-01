using UnityEngine;

public class ClickManager : MonoBehaviour
{
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                Shape shape = hit.collider.GetComponent<Shape>();
                if (shape != null)
                {
                    shape.Interact();
                }
            }
        }
    }
}
