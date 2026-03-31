using UnityEngine;
using UnityEditor;

public class HelloWorld : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    private string info = "Game Over";
    private float aNum = 42;

    // GUI Text
    private string text1;
    private string text2;
    private string textPos;

    void Start()
    {
        Debug.Log("Hello World!");
        Debug.Log("Info string contains: " + info);

        float res = 20 + aNum;
        // Debug.Log("res contains: " + res);
        Debug.Log($"res contains: {res}");
        
        text1 = "Hello World";
        text2 = "Info String contains: " + info;

        textPos = "My position: " + transform.position.ToString();
        // textPos = carName + transform.position.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnGUI()
    {
        GUI.color = Color.magenta;
        GUI.Label(new Rect(10, 10, Screen.width, Screen.height), text1);
        GUI.color = Color.red;
        GUI.Label(new Rect(10, 30, Screen.width, Screen.height), text2);
    }

    private void OnDrawGizmos()
    {
        GUIStyle style = new GUIStyle();
        style.normal.textColor = Color.blue;
        // Handles.Label(transform.position + Vector3.up * 2.5f, textPos, style);
        Handles.Label(transform.position + Vector3.up * 2.5f, "My position: " + transform.position.ToString(),
    style);
    }
}
