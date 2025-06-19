public class Node
{
    public int Data { get; set; }
    public Node? Right { get; private set; }
    public Node? Left { get; private set; }

    public Node(int data)
    {
        this.Data = data;
    }

    public void Insert(int value)
    {
        // TODO Start Problem 1
        if (value == Data)
        {
            return; 
        }
        else if (value < Data)
        {
            // Insert to the left
            if (Left is null)
                Left = new Node(value);
            else
                Left.Insert(value);
        }
        else
        {
            // Insert to the right
            if (Right is null)
                Right = new Node(value);
            else
                Right.Insert(value);
        }
    }

    public bool Contains(int value)
    {
        // TODO Start Problem 2
        if (value == Data)
            return true;
        else if (value < Data && Left is not null)
        {
            return Left.Contains(value);
        }
        else if (value > Data && Right is not null)
        {
            return Right.Contains(value);
        }
        else
        {
            return false;
        }
        
    }

    public int GetHeight()
    {

        // TODO Start Problem 4
        int lefth = 0;
        int righth = 0;
        if (Left is not null)
        {
            lefth = Left.GetHeight();
        }
        if (Right is not null)
        {
            righth = Right.GetHeight();
        }

        return 1 + Math.Max(lefth, righth);
    }
}