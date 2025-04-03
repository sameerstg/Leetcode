public class linkedlist {

	public static void main(String[] args) {
			Node head = new Node(1);
			head.Append(new Node(2));
			head.Append(new Node(3));
			head.Append(new Node(4));
			head.Append(new Node(5));
			head.Append(new Node(6));
			head.Append(new Node(7));

//			head = Node.RemoveAt(head,7);
			head = Node.RemoveAt(head,1);
//			head = Node.AppendAt(head, new Node(0), 0);
			head.Print();
			
//			head.PrintRev();

	}

}
class Node{
	int data;
	Node next;
	Node prev;
	public Node(int data){
		this.data = data;
	}
	public void Append(Node node){
		Node temp = this;
		while(temp.next != null){
			temp = temp.next;
		}
		temp.next = node;
		node.prev= temp;
	}
	public static Node AppendAt(Node head,Node node,int index){
		Node current= head;
		Node prev= null;
		if(0== index){
			node.next= current;
			current.prev= node;
			return node;
		}
		int i=0;
		while(current.next != null && i<index){
			prev = current;
			current.prev = prev;
			current= current.next;
//			current.next.prev = current;
			i++;
		}
		if(i == index){
			node.next= current;
			current.prev = node.next;
			prev.next = node;
			node.prev = prev.next;
			
		}
		return head;
		
		
		
	}
	public static Node RemoveAt(Node head,int data){

		Node current = head.next;
		Node prev = head;
		if(prev.data == data){
			head = current;
			return head;
		}
		do{
			if(current.data == data){
				prev.next = current.next;
				break;
			}
			prev = current;
			current = current.next;
		}
		while(current != null);
		return head;
		
	}
	public void Print(){
		Node temp = this;
		while(temp.next != null){
			System.out.print(temp.data);
			temp = temp.next;
		}
		System.out.print(temp.data);
	}
	public void PrintRev(){
		Node temp = this;
		while(temp.next != null){
//			System.out.print(temp.data);
			temp = temp.next;
		}
//		System.out.print(temp.data);
		while(temp.prev != null){
			System.out.print(temp.data);
			temp = temp.prev;
		}
		System.out.print(temp.data);
	}
}
