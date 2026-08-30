namespace Pro21
{
    internal class Man
    {

    }

    internal class BusinessMan : Man
    {

    }

    internal class StudentMan : Man
    {

    }
    
    internal class PassRefArray
    {
        
        static void Main(string[] args)
        {
            Man m = new BusinessMan();
            BusinessMan bm = (BusinessMan)m;
            StudentMan s = (StudentMan)m;
            //StudentMan s2 = (StudentMan)bm;
        }
    }
}
