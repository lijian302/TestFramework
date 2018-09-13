using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using UnityEngine;

public class TestThread : MonoBehaviour
{
    private Task task;
    private CancellationToken ct;
    private CancellationTokenSource cts;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            cts = new CancellationTokenSource();
            ct = cts.Token;
            task = Task.Run(() =>
            {
                try
                {
                    while (!cts.IsCancellationRequested)
                    {
                        Thread.Sleep(1000);
                        Debug.Log("Sleep");
                        //ct.ThrowIfCancellationRequested();
                    }
                }
                catch (Exception e)
                {
                    Debug.Log(e);
                }
            }, ct);
        }
        else if (Input.GetKeyDown(KeyCode.B))
        {
            if (cts != null)
                cts.Cancel();
        }
        else if (Input.GetKeyDown(KeyCode.C))
        {
            Task<int> task = Delay(1);
            task.GetAwaiter().OnCompleted(() =>
            {
                Debug.Log(task.Result);
            });
        }
    }

    private Task<int> Delay(int time)
    {
        TaskCompletionSource<int> tcs = new TaskCompletionSource<int>();
        new Thread(() =>
        {
            Thread.Sleep(time * 1000);
            tcs.SetResult(time);
        }).Start();
        return tcs.Task;
    }
}
