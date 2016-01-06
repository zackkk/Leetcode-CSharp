Given a binary tree where all the right nodes are either leaf nodes with a sibling 
(a left node that shares the same parent node) or empty, 
flip it upside down and turn it into a tree where the original right nodes turned into left leaf nodes. Return the new root.

For example:
Given a binary tree {1,2,3,4,5},
    1
   / \
  2   3
 / \
4   5
return the root of the binary tree [4,5,2,#,#,3,1].
   4
  / \
 5   2
    / \
   3   1  


/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class Solution {
    // tricky recursion
    public TreeNode UpsideDownBinaryTree(TreeNode root) {
        if(root == null || (root.left == null && root.right == null)) return root;
        
        TreeNode newRoot = UpsideDownBinaryTree(root.left);
        root.left.left = root.right;
        root.left.right = root;
        
        root.left = null;
        root.right = null;
        return newRoot;
    }
}