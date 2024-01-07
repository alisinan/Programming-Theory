using UnityEngine;

public class Shape : MonoBehaviour
{
    // Basic properties of the shape
    protected float size;
    protected Color color;

    // Start is called before the first frame update
    void Start()
    {
        // Initialize default values (these can be adjusted in derived classes)
        size = 1.0f;
        color = Color.white;
    }

    // Update is called once per frame
    void Update()
    {
        // Update logic, if necessary
    }

    // Virtual method for interaction, to be overridden in derived classes
    public virtual void Interact()
    {
        // Default interaction behavior
        Debug.Log("Interacting with a generic shape.");
    }

    // Public getter and setter for size with basic validation
    public float Size
    {
        get { return size; }
        set
        {
            if (value > 0)
            {
                size = value;
            }
            else
            {
                Debug.LogError("Size must be positive.");
            }
        }
    }

    // Public getter and setter for color
    public Color ShapeColor
    {
        get { return color; }
        set { color = value; }
    }
}
