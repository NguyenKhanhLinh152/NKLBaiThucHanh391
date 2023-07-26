namespace NewApp.Models;
public class Employee
{
    public int Manhanvien { get; set; }
    public string Tennhanvien { get; set; }
    public int Tuoi { get; set; }
    public double Luong { get; set; }
    public void Nhapthongtin()
    {
        System.Console.WriteLine("Ma nhan vien: ");
        Console.ReadLine();
        System.Console.WriteLine("Ten nhan vien: ");
        Console.ReadLine();
        System.Console.WriteLine("Tuoi: ");
        Console.ReadLine();
    }
    public void Hienthithongtin()
    {
        System.Console.WriteLine("{0} - {1} - {2} - {3}",Manhanvien,Tennhanvien,Tuoi,Luong);
    }
}
