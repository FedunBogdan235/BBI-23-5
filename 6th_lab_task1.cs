﻿struct Answer
{
    public string famile;
    public double count;
    public Answer(string famile, double count)
    {
        this.famile = famile;
        this.count = count;
    }
    public string Famile { get { return famile; } set { famile = value; } }
    public double Count { get { return count; } set { count = value; } }
}

class Program
{
    static void Main(string[] args)
    {
        Answer[] cl = new Answer[6];
        cl[0] = new Answer("James", 10);
        cl[1] = new Answer("Pedro", 9);
        cl[2] = new Answer("Bogdan", 2);
        cl[3] = new Answer("Alex", 4);
        cl[4] = new Answer("Mark", 13);
        cl[5] = new Answer("Alexandra", 23);
        double sum = 0;
        for (int i = 0; i < cl.Length; i++)
        {
            sum += cl[i].Count;
        }
        for (int i = 0; i < cl.Length - 1; i++)
        {
            double amax = cl[i].Count;
            int imax = i;
            for (int j = i + 1; j < cl.Length; j++)
            {
                if (amax < cl[j].Count)
                {
                    amax = cl[j].Count;
                    imax = j;
                }
            }
            Answer temp;
            temp = cl[imax];
            cl[imax] = cl[i];
            cl[i] = temp;
        }
        double percent = 0;
        for (int i = 0; i < cl.Length; i++)
        {
            percent = cl[i].Count / sum * 100;
            Console.WriteLine(cl[i].Famile + " " + percent);
        }
    }
}