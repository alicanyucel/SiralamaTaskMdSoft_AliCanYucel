namespace SıralamaTask
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void rchtxt1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSayiUret_Click(object sender, EventArgs e)
        {


            MessageBox.Show("Sıralama algoritması için selection sort ve buble sort kullanılacak ");
            Random random = new Random(); // 1 mil yon sayıyı rastgele üretecek.
            int[] sayilar = new int[1000];
            rchtxt1.Text += "uretilen sayilar" + "\n";
            for (int i = 0; i < 1000; i++) // pozitif sayı sıralasın 
            {
                int number = random.Next(1, 2147483647); // intin maksimum alacağı değer girildi üretsin bakalım :)
                sayilar[i] = number;
            }
            foreach (int item in sayilar)
            {  // üretilen sayıları bir richtexboxa attım
                rchtxt1.Text += item.ToString() + "\n";
            }
            rchtxt1.Text += "Selection Sort ile Sıralı Liste" + "\n";
            // selection sort ile sıralasın
            int gecici, ek;
            for (int i = 0; i < 1000; i++)
            {
                ek = i; // dizinin ilk elemanı en kucuk eleman olarak kabul et ve karşılaştır
                for (int j = i + 1; j < 1000; j++)
                {
                    if (sayilar[j] < sayilar[ek])
                    {
                        ek = j;
                    }
                }
                gecici = sayilar[ek];
                sayilar[ek] = sayilar[i];
                sayilar[i] = gecici;
            }
            // sıralı listeyi görelim
            foreach (int item in sayilar)
            {
                rchtxt1.Text += item.ToString() + "\n";
            }
            rchtxt1.Text += "buble sort algoritmasi ile siralama" + "\n";
            // buble sortla da sıralayalım

            for (int j = 0; j <= 998; j++)
            {
                for (int i = 0; i <= 998; i++)
                {
                    if (sayilar[i] > sayilar[i + 1])
                    {
                        gecici =sayilar[i + 1];
                        sayilar[i + 1] = sayilar[i];
                        sayilar[i] = gecici;
                    }
                }
            }
            foreach (var item in sayilar)
            {
                rchtxt1.Text += item.ToString() + "\n";
            }
            // sıralanan diziyi richtextboxa yazdırıyoruz....
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Ali Can Yücel- Yazılım Yüksek Mühendisi - Ahmet Yesevi Üniversitesi");
        }
    }
}
