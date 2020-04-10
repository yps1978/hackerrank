/*
    Node is defined as
    var Node = function(data) {
        this.data = data;
        this.left = null;
        this.right = null;
    }
*/

// This is a "method-only" submission.
// You only need to complete this method.

function levelOrder(root) {
    var children = [root];
    var buffer="";
    while (children.length){
        for (var i=0; i<children.length; i++)
            buffer+= children[i].data + " ";
        var nextLevel=[];
        for (var j=0; j<children.length; j++)
        {
            if (children[j].left!=null)
                nextLevel.push(children[j].left);
            if (children[j].right!=null)
                nextLevel.push(children[j].right);
        }
        children=nextLevel;
    }
    console.log(buffer);
}
