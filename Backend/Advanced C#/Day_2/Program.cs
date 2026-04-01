using Day_2;

Point[] points = new Point[2];
//for (int i = 0; i < 2; i++)
//{

//    Console.WriteLine($"enter point {i+1}");
//    Console.Write("x: ");
//    int.TryParse(Console.ReadLine()!, out int x);
//    Console.Write("y: ");
//    int.TryParse(Console.ReadLine()!, out int y);
//    Console.Write("z: ");
//    int.TryParse(Console.ReadLine()!, out int z);
//    points[i] = new Point(x, y,z);
//}
//points.Sort();


    NIC nic1 = NIC.Create("Intel", "00:1A:2B:3C:4D:5E", TypeOfNIC.Ethernet);
    NIC nic2 = NIC.Create("Intel", "00:1A:2B:3C:4D:5E", TypeOfNIC.Ethernet);

Console.WriteLine(nic1.GetHashCode());
Console.WriteLine(nic2.GetHashCode());