namespace CSHARP_TinhTong
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tinh_Click(object sender, EventArgs e)
        {
            int a, b, sum = 0,tich = 1,tongchan = 0,tongle=0;
            a = Convert.ToInt32(sodau.Text);
            b = Convert.ToInt32(socuoi.Text);

            for(int i = a; i <= b; i++)
            {
                sum += i;
            }
            tong.Text = sum.ToString();

            for(int i = a; i <=b; i++)
            {
                tich *= i;
            }    
            Tich.Text = tich.ToString();

            for(int i = a; i <= b; i++)
            {
                if(i%2==0)
                {
                    tongchan += i;
                }  
            }
            Tongchan.Text = tongchan.ToString();

            for(int i = a; i <= b;i++)
            {
                if(i%2!=0)
                {
                    tongle += i;
                }    
            }  
            Tongle.Text = tongle.ToString();
        }
    }
}
