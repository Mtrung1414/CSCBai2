using System;
/* BT Bien & Hang  */
/*BT1: Nhập vào 2 số nguyên dương a, b từ bàn phím. Tỉnh tổng, hiệu, tích, thương của 2
số vừa nhập và hiển thị kết quả ra màn hình
class BT1
{
    static void Main()
    {
        int a, b;
        Console.Write("Nhap vao so nguyen a: ");
        a = int.Parse(Console.ReadLine());

        Console.Write("Nhap vao so nguyen b: ");
        b = int.Parse(Console.ReadLine());

        int tong = a + b;
        int hieu = a - b;
        int tich = a * b;
        double thuong = a / b;
        Console.WriteLine($"Tong la :{tong}");
        Console.WriteLine($"Hieu la :{hieu}");
        Console.WriteLine($"Tich la :{tich}");
        Console.WriteLine($"Thuong la:{thuong}");

    }
}
*/
/*bài 2: nhập vào 2 cạnh của hình chữ nhật, tính diện tích, chu vi và hiển thị kết quả ra màn
hình

   class bt2
{
    static void main()
    {
        double d, r;

        console.writeline("nhap chieu dai hcn: ");
        d = double.parse(console.readline());
        console.writeline("nhap chieu rong hcn: ");
        r = double.parse(console.readline());

        double s = d * r;
        double p = 2*(d+r);

        console.writeline($"hcn co dien tich= {s}\t chu vi= {p}");
    }
}
*/
/*bài 3: nhập vào đường kính hình tròn, tính bán kính, chu vi, diện tích hình tròn và hiển
thị kết quả ra màn hình

    class bt3
{
    static void main()
    {
        double r;
        console.writeline("nhap vao duong kinh hinh tron: ");
        r = double.parse(console.readline());

        double r = r / 2;
        double s = 2 *math.pi* r; 
        double p = math.pi * math.pow(r, 2);

        console.writeline($"hinh tron co s = {s} ||\t p= {p}");
    }
}
*/
/*bài 4: nhập vào thông tin học sinh bao gồm: họ tên, lớp, điểm trung bình hki, điểm trung bình hkii. tính điểm trung bình cả năm và hiển thị kết quả ra màn hình. biết rằng điểm
trung bình cả năm được tính theo công thức sau: (đtb hki + đtb hkii * 2)/ 3

class bt4
{
    static void main()
    {
        console.writeline("nhap ho ten sv: ");
        string hoten = console.readline();

        console.write("nhap lop sv: ");
        string lop = console.readline();

        console.writeline("nhap dtb hki: ");
        double dtbhk1 = convert.todouble(console.readline());

        console.writeline("nhap dtb hkii: ");
        double dtbhk2 = convert.todouble(console.readline());

        double dtb = (dtbhk1 + dtbhk2) / 2;

        console.writeline("\nket qua hoc tap");
        console.writeline($"\nten hoc sinh: {hoten}");
        console.writeline($"\nlop: {lop}");
        console.writeline($"\ndiem trung binh ca nam: {dtb}");
    }
}*/
/*bài 5: bổ sung thông tin cho 2 nhân viên phòng hành chính bao gồm các thông tin sau: họ tên, giới tính, ngày sinh, hệ số lương, lương cơ bản, số năm làm việc, phụ cấp nhân viên
và hiển thị thông tin các nhân viên ra màn hình. biết rằng nhân viên có số năm làm việc
hơn 5 năm thì phụ cấp nhân viên được tính bằng ½ lương cơ bản.

class nhanvien
{
    public string hoten { get; set; }
    public string gioitinh { get; set; }
    public DateTime ngaysinh {  get; set; }
    public double hesoluong {  get; set; }
    public double luongcoban {  get; set; }
    public int sonamlam {  get; set; }
    public double phucap { get; set; }

    public void NhapThongTin()
    {
        Console.WriteLine("Nhap ho ten : ");
        hoten = Console.ReadLine();

        Console.WriteLine("Nhap gioi tinh: ");
        gioitinh = Console.ReadLine();

        Console.WriteLine("Nhap ngay sinh: ");
        ngaysinh = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);

        Console.WriteLine("Nhap he so luong");
        hesoluong = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Nhap luong co ban: ");
        luongcoban = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Nhap so nam lam: ");
        sonamlam = Convert.ToInt32(Console.ReadLine());

        if (sonamlam > 5) phucap = luongcoban / 2;
        else phucap = 0;
    }
    public void HienThiTT()
    {
        Console.WriteLine("\nThong tin nhan vien");
        Console.WriteLine($"\nHo ten: {hoten}");
        Console.WriteLine($"\nGioi Tinh: {gioitinh}");
        Console.WriteLine($"\nNgay sinh: {ngaysinh}");
        Console.WriteLine($"\nHe so luong: {hesoluong}");
        Console.WriteLine($"luong co ban: {luongcoban}");
        Console.WriteLine($"\nSo nam lam: {sonamlam}");
        Console.WriteLine($"\nPhu Cap: {phucap}");
    }      
}

    class TTC
{
    static void Main()
    {
        // Tạo 2 đối tượng nhân viên:
        nhanvien nv1 = new nhanvien();
        nhanvien nv2 = new nhanvien();

        // Nhap thông tin cho nhân viên:
        Console.WriteLine("Nhap Thong tin nhan vien thu nhat: ");
        nv1.NhapThongTin();

        Console.WriteLine("Nhap thong tin nhan vien thu 2:");
        nv2.NhapThongTin();

        // Hiển thị tt nhân viên
        Console.WriteLine("Thong Tin 2 nhan vien:");
        nv1.HienThiTT();
        nv2.HienThiTT();
    }
}*/
/*Bài 6: Nhập vào ngày, tháng và năm bất kỳ, hãy hiển thị ra màn hình kết quả của ngày hôm qua, ngày mai. 
class bt6
{
    static void Main()
    {
        Console.WriteLine("Nhap ngay thang nam ban muon:");
        Console.WriteLine("Nhap ngay:");
        int ngay = int.Parse(Console.ReadLine());

        Console.WriteLine("Nhap Thang: ");
        int thang = int.Parse(Console.ReadLine());

        Console.WriteLine("Nhap nam");
        int nam = int.Parse(Console.ReadLine());

        try
        {
            DateTime ngayhientai = new DateTime(nam, thang, ngay);

            DateTime ngayhomqua = ngayhientai.AddDays(-1);
            DateTime ngaymai = ngayhientai.AddDays(+1);

            Console.WriteLine($"Ngay hom nay: {ngayhientai.ToString("dd/MM/yyyy")}");
            Console.WriteLine($"Ngay hom qua: {ngayhomqua.ToString("dd/MM/yyyy")}");
            Console.WriteLine($"Ngay mai: {ngaymai.ToString("dd/MM/yyyy")}");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Ngay thang nam khong hop le!!");
        }
    }
}*/


/* BT DieuKien & CauTruc */