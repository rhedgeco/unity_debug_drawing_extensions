using UnityEngine;
using DebugExtensions;

[ExecuteInEditMode]
public class ExampleDebugDraw : MonoBehaviour
{
    void Update()
    {
        DebugExtension.DrawWireSphere(new Vector3(1, -1f, 0), 0.5f, Color.green);
        DebugExtension.DrawCircle(new Vector3(-0.75f, -1.25f, 0), new Vector3(1, 1, 1), 1, Color.magenta);
        DebugExtension.DrawRectangularPrism(new Vector3(0, 0f, 0.5f), new Vector3(2f, 1, -0.5f),
            Color.blue);
        DebugExtension.DrawCube(new Vector3(-1.5f, 0.5f, 0), 1, Color.red);
    }
}