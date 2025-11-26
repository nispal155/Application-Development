namespace task3_2;

class Program
{
    static void Main(string[] args)
    {
        NepaliTeacher nt = new NepaliTeacher();
        nt.Teaching();
        nt.SalaryInfo();
        EnglishTeacher et = new EnglishTeacher();
        et.Teaching();
        et.SalaryInfo();

    }
}
