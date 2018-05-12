using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlingShotManager : MonoBehaviour
{

    public Transform leftAnchor;
    public Transform rightAnchor;
    public Transform ObjectHolder;
    public LineRenderer[] lines;

    public static SlingShotManager instance;

    void Awake()
    {
        instance = this;
    }

    // Use this for initialization

    void Start()
    {
        lines[0].SetPosition(0, leftAnchor.position);
        lines[1].SetPosition(0, rightAnchor.position);
    }

    // Update is called once per frame

    void Update()
    {
        for (int i = 0; i < lines.Length; i++)
        {
            lines[i].SetPosition(1, ObjectHolder.position);
        }
    }
 }