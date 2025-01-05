namespace veriCıkmısSorular;

class Program
{
    class Block
    {
        public Block next;
        public int data;
    }
    static void Main(string[] args)
    {
        // Diziyi rastgele sayılarla dolduruyoruz
        Random rnd = new Random();
        int[] arr = new int[100];
        for (int i = 0; i < 100; i++)
        {
            arr[i] = rnd.Next(0, 1000);
        }

// Bağlı listeye ekleme
        Block head = null;

        for (int i = 0; i < arr.Length; i++)
        {
            Block newNode = new Block();
            newNode.data = arr[i];
    
            if (head == null || head.data >= newNode.data) // Başa ekleme durumu
            {
                newNode.next = head;
                head = newNode;
            }
            else // Doğru yeri bulup araya ekleme
            {
                Block current = head;
                while (current.next != null && current.next.data < newNode.data)
                {
                    current = current.next;
                }
        
                newNode.next = current.next;
                current.next = newNode;
            }
        }
        // Bağlı listeyi yazdırma
        Block temp = head;
        while (temp != null)
        {
            Console.WriteLine(temp.data + " ");
            temp = temp.next;
        }
           
        

    }
}