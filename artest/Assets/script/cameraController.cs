using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraController : MonoBehaviour
{
    private static cameraController instance; // ��̬���ã�����ȷ��ֻ��һ��ʵ��

    private void Awake()
    {
        // ���instance�����ڣ���������Ϊ�������
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject); // ���Ϊ�����ٵĶ���
        }
        else
        {
            // ���instance�Ѿ����ڣ������������ȷ��ֻ��һ�������
            Destroy(gameObject);
        }
    }
}
