using System.Runtime.InteropServices.Marshalling;

public class Programm
{
    public static void Main()
    {
        int[] rec1 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int[] rec2 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        Console.WriteLine(IsRectangleOverlap(rec1, rec2));
    }
    
    public static bool IsRectangleOverlap(int[] rec1, int[] rec2)
    {
        int[] rec1Left0 = { rec1[0], rec1[1] }, rec1Left1 = {rec1[2], rec1[1]}, rec1Right0 = {rec1[0], rec1[3]}, rec1Right1 = {rec1[2], rec1[3]};
        int[] rec2Left0 = { rec2[0], rec2[1] }, rec2Left1 = {rec2[2], rec1[1]}, rec2Right0 = {rec2[0], rec2[3]}, rec2Right1 = {rec2[2], rec2[3]};
        bool isRec1InRec2 = isPointInOtherRec(rec1Left0, rec2) || isPointInOtherRec(rec1Left1, rec2) || isPointInOtherRec(rec1Right0, rec2) || isPointInOtherRec(rec1Right1, rec2);
        bool isRec2InRec1 = isPointInOtherRec(rec2Left0, rec1) || isPointInOtherRec(rec2Left1, rec1) || isPointInOtherRec(rec2Right0, rec1) || isPointInOtherRec(rec2Right1, rec1);
        return isRec1InRec2 || isRec2InRec1;
    }

    public static bool isPointInOtherRec(int[] point, int[] rec)
    {
        return point[0] > rec[0] && point[0] < rec[2] && point[1] > rec[1] && point[1] < rec[3];
    }
}