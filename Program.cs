namespace DataStructures_BinarySearchTree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Binary Search Tree Problems \n");

            BinarySearchTree<int> objBinary = new BinarySearchTree<int>(56);
            objBinary.Add(30);
            objBinary.Add(70);
            Console.WriteLine("\nElements in the Binary Tree are : \n");
            
            objBinary.Display();
        }
    }
}