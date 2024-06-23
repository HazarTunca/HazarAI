using System;
using BehaviourTree.Scripts.Nodes;
using BehaviourTree.Scripts.Nodes.Composite;
using BehaviourTree.Scripts.Nodes.Leaf;
using UnityEngine;

namespace BehaviourTree.Scripts
{
    // EXAMPLE USAGE:
    public class BehaviourTreeAI : MonoBehaviour
    {
        public BehaviourTree behaviourTree;

        void Awake()
        {
            behaviourTree = new BehaviourTree(
                new BTSelectorComposite()
                {
                    nodes = new BTNode[]
                    {
                        new BTSequenceComposite()
                        {
                            nodes = new BTNode[]
                            {
                                new BTActionLeaf()
                                {
                                    btAction = () =>
                                    {
                                        Debug.Log("Action 1");
                                        return BTNode.NodeState.Success;
                                    }
                                },
                                new BTActionLeaf()
                                {
                                    btAction = () =>
                                    {
                                        Debug.Log("Action 2");
                                        return BTNode.NodeState.Failure;
                                    }
                                },
                            }
                        },
                        new BTSelectorComposite()
                        {
                            nodes = new BTNode[]
                            {
                                new BTSequenceComposite()
                                {
                                    nodes = new BTNode[]
                                    {
                                        new BTActionLeaf()
                                        {
                                            btAction = () =>
                                            {
                                                Debug.Log("Action 3");
                                                return BTNode.NodeState.Failure;
                                            }
                                        },
                                        new BTActionLeaf()
                                        {
                                            btAction = () =>
                                            {
                                                Debug.Log("Action 4");
                                                return BTNode.NodeState.Success;
                                            }
                                        },
                                    }
                                },
                            }
                        }
                    }
                }
            );
        }
        
        void Update()
        {
            behaviourTree.Update();
        }
    }
}