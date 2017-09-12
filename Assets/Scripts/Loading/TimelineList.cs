using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimelineList : MonoBehaviour
{

    [SerializeField] private GameObject _TimelineObjPrefab = null;
    [SerializeField] private ScrollRect _TimelineListView = null;

    void Awake()
    {
        for (int i = 0; i < 10; ++i)
        {

            var obj = Instantiate(_TimelineObjPrefab);

            obj.transform.SetParent(_TimelineListView.content);
        }
    }

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
