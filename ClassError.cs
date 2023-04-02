using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


internal static class ClassError
{
    public static bool CheckPoints(point[] points, screen screen1, string detailName, string text="рисовании")
    {
        bool error = false;
        try
        {
            for (int i = 0; i < points.Length; i++)
            {
                CheckPoint(points[i], screen1);
            }
        }
        catch (Exception e)
        {
            error = true;
            Console.WriteLine("При {0} объекта {1} возникла ошибка:",text, detailName);
            Console.WriteLine(e.Message);
            Console.WriteLine("------------------------");

        }
        return error;


    }

    private static void CheckPoint(point point, screen screen1)
    {
        if (point.x < 0 || point.x >= screen1.GetWidth() || point.y < 0 || point.y>screen1.GetHeight())
        {
            throw new Exception("Точка вне границ экрана");
        }
    }

    public static bool CheckWasReflected(bool reflected, string detailName)
    {
        bool error = false;
        try
        {
            if (reflected == true)
            {
                throw new Exception("Объект " + detailName + " уже был отражён");

            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            Console.WriteLine("------------------------");
            error = true;


        }
        return error;
    }


    public static bool CheckWasRotated(bool rotated, string detailName)
    {
        bool error = false;
        try
        {
            if (rotated == true)
            {
                throw new Exception("Объект " + detailName + " уже был повернут");

            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            Console.WriteLine("------------------------");
            error = true;

        }
        return error;
    }

    public static bool CheckParameters(point a, point b, string detailName, string text="")
    {
        bool error = false;
        try
        {
            if (a.x>b.x || a.y>b.y)
            {
                throw new Exception("Некорректные параметры при формированиии фигуры "+ detailName+" "+text);
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            Console.WriteLine("------------------------");
            error = true;

        }
        return error;

    }

    public static bool CheckParametersLine(point a, point b, string detailName, string text = "")
    {
        bool error = false;
        try
        {
            if (a.x > b.x)
            {
                throw new Exception("Некорректные параметры при формированиии фигуры " + detailName + " " + text);
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            Console.WriteLine("------------------------");
            error = true;

        }
        return error;

    }
}

