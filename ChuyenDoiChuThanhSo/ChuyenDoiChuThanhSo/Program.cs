using System.Text;

public class Program
{

    private static string NumberToText(string number)
    {
        string result = "";
        switch (number)
        {
            case "0":
                result = "không";
                break;
            case "1":
                result = "một";
                break;
            case "2":
                result = "hai";
                break;
            case "3":
                result = "ba";
                break;
            case "4":
                result = "bốn";
                break;
            case "5":
                result = "năm";
                break;
            case "6":
                result = "sáu";
                break;
            case "7":
                result = "bảy";
                break;
            case "8":
                result = "tám";
                break;
            case "9":
                result = "chín";
                break;
        }
        return result;
    }
    private static string Unit(string so)
    {
        string unit = "";

        if (so.Equals("1"))
            unit = "";
        if (so.Equals("2"))
            unit = "nghìn";
        if (so.Equals("3"))
            unit = "triệu";
        //if (so.Equals("4"))
        //    Kdonvi = "tỷ";
        //if (so.Equals("5"))
        //    Kdonvi = "nghìn tỷ";
        //if (so.Equals("6"))
        //    Kdonvi = "triệu tỷ";
        //if (so.Equals("7"))
        //    Kdonvi = "tỷ tỷ";

        return unit;
    }
    private static string numberSeperation(string tach)
    {
        string word = "";
        if (tach.Equals("000"))
            return "";
        if (tach.Length == 3)
        {
            string tr = tach.Trim().Substring(0, 1).ToString().Trim();
            string ch = tach.Trim().Substring(1, 1).ToString().Trim();
            string dv = tach.Trim().Substring(2, 1).ToString().Trim();
            if (tr.Equals("0") && ch.Equals("0"))
                word = " không trăm linh " + NumberToText(dv.ToString().Trim()) + " ";
            if (!tr.Equals("0") && ch.Equals("0") && dv.Equals("0"))
                word = NumberToText(tr.ToString().Trim()).Trim() + " trăm ";
            if (!tr.Equals("0") && ch.Equals("0") && !dv.Equals("0"))
                word = NumberToText(tr.ToString().Trim()).Trim() + " trăm linh " + NumberToText(dv.Trim()).Trim() + " ";

            if (tr.Equals("0") && Convert.ToInt32(ch) > 1 && Convert.ToInt32(dv) > 0 && !dv.Equals("5"))
                word = " không trăm " + NumberToText(ch.Trim()).Trim() + " mươi " + NumberToText(dv.Trim()).Trim() + " ";
            if (tr.Equals("0") && Convert.ToInt32(ch) > 1 && dv.Equals("0"))
                word = " không trăm " + NumberToText(ch.Trim()).Trim() + " mươi ";
            if (tr.Equals("0") && Convert.ToInt32(ch) > 1 && dv.Equals("5"))
                word = " không trăm " + NumberToText(ch.Trim()).Trim() + " mươi lăm ";
            if (tr.Equals("0") && ch.Equals("1") && Convert.ToInt32(dv) > 0 && !dv.Equals("5"))
                word = " không trăm mười " + NumberToText(dv.Trim()).Trim() + " ";
            if (tr.Equals("0") && ch.Equals("1") && dv.Equals("0"))
                word = " không trăm mười ";
            if (tr.Equals("0") && ch.Equals("1") && dv.Equals("5"))
                word = " không trăm mười lăm ";
            if (Convert.ToInt32(tr) > 0 && Convert.ToInt32(ch) > 1 && Convert.ToInt32(dv) > 0 && Convert.ToInt32(dv) == 1 && !dv.Equals("5"))
                word = NumberToText(tr.Trim()).Trim() + " trăm " + NumberToText(ch.Trim()).Trim() + " mươi mốt";
            if (Convert.ToInt32(tr) > 0 && Convert.ToInt32(ch) > 1 && Convert.ToInt32(dv) > 0 && Convert.ToInt32(dv) != 1 && !dv.Equals("5"))
                word = NumberToText(tr.Trim()).Trim() + " trăm " + NumberToText(ch.Trim()).Trim() + " mươi " + NumberToText(dv.Trim()).Trim() + " ";
            if (Convert.ToInt32(tr) > 0 && Convert.ToInt32(ch) > 1 && dv.Equals("0"))
                word = NumberToText(tr.Trim()).Trim() + " trăm " + NumberToText(ch.Trim()).Trim() + " mươi ";
            if (Convert.ToInt32(tr) > 0 && Convert.ToInt32(ch) > 1 && dv.Equals("5"))
                word = NumberToText(tr.Trim()).Trim() + " trăm " + NumberToText(ch.Trim()).Trim() + " mươi lăm ";
            if (Convert.ToInt32(tr) > 0 && ch.Equals("1") && Convert.ToInt32(dv) > 0 && !dv.Equals("5"))
                word = NumberToText(tr.Trim()).Trim() + " trăm mười " + NumberToText(dv.Trim()).Trim() + " ";

            if (Convert.ToInt32(tr) > 0 && ch.Equals("1") && dv.Equals("0"))
                word = NumberToText(tr.Trim()).Trim() + " trăm mười ";
            if (Convert.ToInt32(tr) > 0 && ch.Equals("1") && dv.Equals("5"))
                word = NumberToText(tr.Trim()).Trim() + " trăm mười lăm ";

        }


        return word;

    }
    public static string ChuyenSoThanhChu(double number)
    {
        if (number == 0)
            return "không";

        string lso_chu = "";
        string tach_mod = "";
        string tach_conlai = "";
        double Num = Math.Round(number, 0);
        string gN = Convert.ToString(Num);
        int m = Convert.ToInt32(gN.Length / 3);
        int mod = gN.Length - m * 3;
        string dau = "[+]";


        if (number < 0)
            dau = "[-]";
        dau = "";


        if (mod.Equals(1))
            tach_mod = "00" + Convert.ToString(Num.ToString().Trim().Substring(0, 1)).Trim();
        if (mod.Equals(2))
            tach_mod = "0" + Convert.ToString(Num.ToString().Trim().Substring(0, 2)).Trim();
        if (mod.Equals(0))
            tach_mod = "000";

        if (Num.ToString().Length > 2)
            tach_conlai = Convert.ToString(Num.ToString().Trim().Substring(mod, Num.ToString().Length - mod)).Trim();


        int im = m + 1;
        if (mod > 0)
            lso_chu = numberSeperation(tach_mod).ToString().Trim() + " " + Unit(im.ToString().Trim());


        int i = m;
        int _m = m;
        int j = 1;
        string tach3 = "";
        string tach3_ = "";

        while (i > 0)
        {
            tach3 = tach_conlai.Trim().Substring(0, 3).Trim();
            tach3_ = tach3;
            lso_chu = lso_chu.Trim() + " " + numberSeperation(tach3.Trim()).Trim();
            m = _m + 1 - j;
            if (!tach3_.Equals("000"))
                lso_chu = lso_chu.Trim() + " " + Unit(m.ToString().Trim()).Trim();
            tach_conlai = tach_conlai.Trim().Substring(3, tach_conlai.Trim().Length - 3);

            i = i - 1;
            j = j + 1;
        }
        //xet unit hang trieu ty
        if (lso_chu.Trim().Substring(0, 1).Equals("k"))
            lso_chu = lso_chu.Trim().Substring(10, lso_chu.Trim().Length - 10).Trim();
        if (lso_chu.Trim().Substring(0, 1).Equals("l"))
            lso_chu = lso_chu.Trim().Substring(2, lso_chu.Trim().Length - 2).Trim();
        if (lso_chu.Trim().Length > 0)
            lso_chu = dau.Trim() + " " + lso_chu.Trim().Substring(0, 1).Trim().ToUpper() + lso_chu.Trim().Substring(1, lso_chu.Trim().Length - 1).Trim();

        return lso_chu.ToString().Trim();

    }
    public static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        double so;

        so = Double.Parse(Console.ReadLine());

        while (so < 1000)
        {
            Console.WriteLine(ChuyenSoThanhChu(so));
            so = Double.Parse(Console.ReadLine());
        }

    }

}
