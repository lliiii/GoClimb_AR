using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraController : MonoBehaviour
{
    private static cameraController instance; // 静态引用，用于确保只有一个实例

    private void Awake()
    {
        // 如果instance不存在，将其设置为这个对象
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject); // 标记为不销毁的对象
        }
        else
        {
            // 如果instance已经存在，销毁这个对象，确保只有一个摄像机
            Destroy(gameObject);
        }
    }
}
