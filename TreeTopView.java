   /* 
    
    class Node 
       int data;
       Node left;
       Node right;
   */
   void topView(Node root) {
       Node aux=root;
       String sb="";
       while (aux!=null)
       {
           sb = aux.data + " " +sb;
           aux=aux.left;
       }
       sb=sb.trim();
       aux=root.right;
       while (aux!=null)
       {
           sb = sb + " " + aux.data;
           aux=aux.right;
       }
       System.out.println(sb);
    }
