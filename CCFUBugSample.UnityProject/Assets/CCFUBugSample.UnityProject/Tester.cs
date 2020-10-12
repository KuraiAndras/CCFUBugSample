using System;
using UnityEngine;

namespace CCFUBugSample.UnityProject
{
    public class Tester : MonoBehaviour
    {
        private void Start() => Debug.Log(new SampleService().TestSwitch(2));
    }
}
