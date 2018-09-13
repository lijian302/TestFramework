using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestFramework : MonoBehaviour
{
    private NodeList<string, int> nodeList;

    // Use this for initialization
    void Start()
    {
        nodeList = new NodeList<string, int>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            nodeList.ClearNodes();
            nodeList.AddNode("message", 1);
            nodeList.AddNode("message", 2);
            nodeList.AddNode("message", 3);
            nodeList.AddNode("message", 4);
            nodeList.AddNode("message", 5);
            nodeList.ShowNodes("message");
        }
        else if (Input.GetKeyDown(KeyCode.B))
        {
            nodeList.RemoveNode("message", 1);
            nodeList.ShowNodes("message");
        }
        else if (Input.GetKeyDown(KeyCode.C))
        {
            nodeList.RemoveNode("message", 3);
            nodeList.ShowNodes("message");
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            nodeList.RemoveNode("message", 5);
            nodeList.ShowNodes("message");
        }
        else if (Input.GetKeyDown(KeyCode.E))
        {
            nodeList.ClearNodes();
            nodeList.AddNode(new string[2] { "message1", "message2" }, 1);
            nodeList.AddNode("message1", 2);
            nodeList.AddNode(new string[2] { "message1", "message2" }, 3);
            nodeList.AddNode("message2", 4);
            nodeList.AddNode(new string[2] { "message1", "message2" }, 5);
            nodeList.ShowNodes("message1");
            nodeList.ShowNodes("message2");
        }
        else if (Input.GetKeyDown(KeyCode.F))
        {
            nodeList.RemoveNode("message1", 1);
            nodeList.ShowNodes("message1");
            nodeList.ShowNodes("message2");
        }
        else if (Input.GetKeyDown(KeyCode.G))
        {
            nodeList.RemoveNode("message2", 5);
            nodeList.ShowNodes("message1");
            nodeList.ShowNodes("message2");
        }
    }
}
