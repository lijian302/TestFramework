using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NodeList<TKey, TValue>
{
    private Dictionary<TKey, Node<TValue>> nodeDic;

    public NodeList()
    {
        nodeDic = new Dictionary<TKey, Node<TValue>>();
    }

    /// <summary>
    /// 添加节点
    /// </summary>
    /// <param name="key"></param>
    /// <param name="value"></param>
    public void AddNode(TKey key, TValue value)
    {
        if (!nodeDic.ContainsKey(key))
        {
            nodeDic.Add(key, new Node<TValue>(value));
        }
        else
        {
            Node<TValue> tempNode = nodeDic[key];
            while (tempNode.next != null)
            {
                tempNode = tempNode.next;
            }
            tempNode.next = new Node<TValue>(value);
        }
    }

    /// <summary>
    /// 添加节点
    /// </summary>
    /// <param name="keys"></param>
    /// <param name="value"></param>
    public void AddNode(TKey[] keys, TValue value)
    {
        foreach (var key in keys)
        {
            AddNode(key, value);
        }
    }

    /// <summary>
    /// 删除节点
    /// </summary>
    /// <param name="key"></param>
    /// <param name="value"></param>
    public void RemoveNode(TKey key, TValue value)
    {
        if (!nodeDic.ContainsKey(key))
        {
            throw new Exception("Key not exist!");
        }
        else
        {
            //value位于头部
            if (nodeDic[key].data.Equals(value))
            {
                //只有一个节点，直接删除key
                if (nodeDic[key].next == null)
                {
                    nodeDic.Remove(key);
                }
                //有下个节点，将头节点指向下个节点
                else
                {
                    nodeDic[key] = nodeDic[key].next;
                }
            }
            //value位于中间、尾部
            else
            {
                Node<TValue> tempNode = nodeDic[key];
                while (tempNode.next != null && !tempNode.next.data.Equals(value))
                {
                    tempNode = tempNode.next;
                }
                //value位于中间，将节点的下个节点指向下个节点
                if (tempNode.next.next != null)
                {
                    tempNode.next = tempNode.next.next;
                }
                //value位于尾部，将节点的下个节点置空
                else
                {
                    tempNode.next = null;
                }
            }
        }
    }

    /// <summary>
    /// 删除节点
    /// </summary>
    /// <param name="keys"></param>
    /// <param name="value"></param>
    public void RemoveNode(TKey[] keys, TValue value)
    {
        foreach (var key in keys)
        {
            RemoveNode(key, value);
        }
    }

    /// <summary>
    /// 清除所有节点
    /// </summary>
    public void ClearNodes()
    {
        nodeDic.Clear();
    }

    /// <summary>
    /// 显示节点
    /// </summary>
    /// <param name="key"></param>
    public void ShowNodes(TKey key)
    {
        if (!nodeDic.ContainsKey(key))
        {
            throw new Exception("Key not exist!");
        }
        else
        {
            Node<TValue> tempNode = nodeDic[key];
            Debug.Log(key + ": " + tempNode.data);
            while (tempNode.next != null)
            {
                tempNode = tempNode.next;
                Debug.Log(key + ": " + tempNode.data);
            }
        }
    }
}

public class Node<T>
{
    public T data;
    public Node<T> next;

    public Node(T data)
    {
        this.data = data;
    }
}
