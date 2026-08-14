namespace Pro22
{
    internal class IteratorBasic
    {
        static void Main(string[] args)
        {
            var dir = new DirectoryInfo(@"C:\Users\hirok\OneDrive\デスクトップ");
            //Console.WriteLine(dir.Exists);
            //Console.WriteLine(dir.Parent);
            //Console.WriteLine(dir.Root);
            //Console.WriteLine(dir.CreationTime);
            //Console.WriteLine(dir.LastAccessTime);
            //Console.WriteLine(dir.LastWriteTime);

            //var dirs = dir.GetDirectories();
            //foreach (var d in dirs)
            //{
            //    Console.WriteLine(d.FullName);
            //}

            var dir2 = new DirectoryInfo(@"C:\Users\hirok\OneDrive\デスクトップ\smp");
            dir2.Create();

            dir2.MoveTo(@"C:\Users\hirok\OneDrive\デスクトップ\test");
            dir2.MoveTo(@"C:\Learning_Programming\hoge");
            dir2.CreateSubdirectory("sub");

            dir2.Delete(true);
        }
    }
}
