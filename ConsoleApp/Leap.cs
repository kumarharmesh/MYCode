using System;
namespace ConsoleApp
{
public class DateManip
{
    public static bool Leap(int year)
    {
        if(year % 4==0)
        {
            if(((year % 400==0)||(year % 100 !=0)))
            return true;
            else
            return false;
        }
        else
        {
            return false;
        }
    }
}

}