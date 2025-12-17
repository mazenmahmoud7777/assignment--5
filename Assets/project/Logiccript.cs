using UnityEngine;

public class LogicScript : MonoBehaviour
{
    public string message = "Hello, Unity!";
    public int x;
    public float y = 6;
    public Color color;

    [SerializeField] private GameObject obj;

    void Start()
    {
        Debug.Log(message);
    }
}
