public class Node
{
    public int Data { get; set; }
    public Node? Right { get; private set; }
    public Node? Left { get; private set; }

    public Node(int data)
    {
        this.Data = data;
    }
//--------------------------------------------Problem 1----Done------------------------------------------------------------------------------------------------------
    public void Insert(int value)
    {
       

        if(value == Data)
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
//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------



//----------------------------------------------Problem 2----------------------------------------------------------------------------------------------------------------
    public bool Contains(int value)
      {
        // TODO Start Problem 2
        if (Data == value)
        {
            return true;
        }
        else if (Data > value)
        {
            if (Left is null)
            {
                return false;
            }
            else
            {
                return Left.Contains(value);
            }
        }
        else
        {
            if (Right is null)
            {
                return false;
            }
            else
            {
                return Right.Contains(value);
            }
        }
    }
//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------
 


 
 //----------------------------------------------Problem 4----------------------------------------------------------------------------------------------------------------
 
    public int GetHeight()
    {
        // TODO Start Problem 4
             if (this is null)
        {
            return 0;
        }
        int lHeight = Left?.GetHeight() ?? 0;
        int rHeight = Right?.GetHeight() ?? 0;

        return Math.Max(lHeight, rHeight) + 1;
    }
}

//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------