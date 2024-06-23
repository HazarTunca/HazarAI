using BehaviourTree.Scripts.Nodes;
using UnityEngine;

namespace BehaviourTree.Scripts
{
    public class BehaviourTree
    {
        public BTNode rootNode;
        
        public BehaviourTree(BTNode rootNode)
        {
            this.rootNode = rootNode;
        }
        
        public void Update()
        {
            rootNode.Execute();
        }
    }
}